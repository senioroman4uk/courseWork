using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Message;
using ProjectType;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for LabControlPage.xaml
    /// </summary>
    public partial class LabControlPage : Page
    {
        List<LabWorks> labsCollection = new List<LabWorks>();
        private LabWorks CurrentLab;
        public LabControlPage()
        {
            InitializeComponent();
            //TreeName.LabControl.IsSelected = true;
            DataGridTextColumn col = new DataGridTextColumn();
            col.Header = "№";
            col.Width = new DataGridLength(30);
            col.Binding = new Binding("ID");
            ProjectsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Назва";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("Name");
            ProjectsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Опис";
            col.Width = new DataGridLength(400);
            col.Binding = new Binding("Description");
            ProjectsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Дедлайн";
            col.Width = new DataGridLength(120);
            col.Binding = new Binding("Deadline");
            ProjectsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "№";
            col.Width = new DataGridLength(30);
            col.Binding = new Binding("ID");
            EventsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Назва";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("Name");
            EventsGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Дедлайн";
            col.Width = new DataGridLength(120);
            col.Binding = new Binding("Deadline");
            EventsGrid.Columns.Add(col);
            UpdateProjects();
            Events.IsEnabled = false;
        }
        private void ProjectsRow_Click(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid) sender;
            if (dg.SelectedIndex != -1)
            {
                CurrentLab = labsCollection[dg.SelectedIndex];
                UpdateEvents();
                Events.IsSelected = true;
                Events.IsEnabled = true;
                EventsGrid.SelectedIndex = 0;
            } 
        }

        private void UpdateProjects()
        {
            ProjectsGrid.Items.Clear();
            labsCollection.Clear();
            foreach (var lw in InitProjectTable())
            {
                var laba = (LabWorks)lw;
                labsCollection.Add(laba);
                var val = new ProjectRow(laba.ID.ToString(), laba.Theme, laba.Description,
                    laba.Events.Count > 0 ? laba.Events[laba.Events.Count - 1].DeadLine.ToLongDateString() : String.Empty);
                ProjectsGrid.Items.Add(val);
            }
        }

        private void UpdateEvents()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_PROJECT_BY_ID;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, CurrentLab.ID);
                        CurrentLab = (LabWorks)formatter.Deserialize(writerStream);
                        if (CurrentLab.ID != 0)
                        {
                            EventsGrid.Items.Clear();
                            Labname.Text = CurrentLab.Theme;
                            LabSubject.Text = CurrentLab.Subject;
                            LabDescription.Text = CurrentLab.Description;
                            foreach (Event ev in CurrentLab.Events)
                            {
                                EventsGrid.Items.Add(new EventRow(ev.SerialNumber.ToString(), ev.Title,
                                    ev.DeadLine != new DateTime() ? ev.DeadLine.ToLongDateString() : String.Empty));
                            }
                            if (CurrentLab.Events.Count != 0)
                            {
                                
                                EditEvent.IsEnabled = true;
                            }
                            else
                            {
                                EditEvent.IsEnabled = false;
                            }
                        }
                        else
                        {

                            // TODO перезапускать окно как-то
                            MessageBox.Show("Помилка оновлення інформації. Перезайдіть в програму");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void EventsRow_Click(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
        }

        public List<Project> InitProjectTable()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG(); 
                        message.stat = STATUS.GET_LABS_BY_INSTRUCTOR;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, (App.Current as App).instr.InstructorId);
                        return (List<Project>) formatter.Deserialize(writerStream);
                    }
                }
            }
            catch (Exception)
            {
            }
            return new List<Project>();
        }
        
        private void AddLab_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow w = new AddProjectWindow(CurrentWindow.CreateLab);
            w.ShowDialog();
            UpdateProjects();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.ProjectControl.IsExpanded = true;
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow w = new AddEventWindow(CurrentWindow.AddEvent, (Project)CurrentLab);
            w.ShowDialog();
            UpdateEvents();

        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            int ind = EventsGrid.SelectedIndex;
            UpdateEvents();
            if (ind < 0)
            {
                MessageBox.Show("Оберіть роботу");
            }
            else
            {
                EditEventWindow w = new EditEventWindow((Project)CurrentLab, ind);
                w.ShowDialog();
                UpdateEvents();   
            }
        }

        private void EditLab_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow w = new AddProjectWindow(CurrentWindow.EditLab, CurrentLab);
            w.ShowDialog();
        }

        private void Projects_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateProjects();
        }

        private void Events_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateEvents();
        }

        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            int index = EventsGrid.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Оберіть івент");
            }
            else
            {
                try
                {
                    Configuration config = (App.Current as App).config;
                    using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                    {
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.DELETE_EVENT;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, CurrentLab.Events[index].ID);
                        }
                    }
                }
                catch (Exception)
                {
                }
                UpdateEvents();   
            }
        }

        private void DeleteLab_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
