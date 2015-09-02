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
    /// Interaction logic for CourseControlPage.xaml
    /// </summary>
    public partial class CourseControlPage : Page
    {
        public CourseControlPage()
        {
            InitializeComponent();
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

            //Events.IsEnabled = false;
        }
        private void ProjectsRow_Click(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Events.IsEnabled = true;
            
        }
        private void EventsRow_Click(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;

        }

        private void AddLab_Click(object sender, RoutedEventArgs e)
        {
            //AddProjectWindow w = new AddProjectWindow(CurrentWindow.CreateLab);
            //w.ShowDialog();
            //UpdateProjects();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.ProjectControl.IsExpanded = true;
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            //AddEventWindow w = new AddEventWindow(CurrentWindow.AddEvent, (Project)CurrentLab);
            //w.ShowDialog();
            //UpdateEvents();

        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            //int ind = EventsGrid.SelectedIndex;
            //UpdateEvents();
            //AddEventWindow w = new AddEventWindow(CurrentWindow.EditEvent, (Project)CurrentLab, ind);
            //w.ShowDialog();
            //UpdateEvents();
        }

        private void EditLab_Click(object sender, RoutedEventArgs e)
        {
            //AddProjectWindow w = new AddProjectWindow(CurrentWindow.EditLab, CurrentLab);
            //w.ShowDialog();
        }
        private void Projects_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //UpdateProjects();
        }

        private void Events_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //UpdateEvents();
        }
    }
}
