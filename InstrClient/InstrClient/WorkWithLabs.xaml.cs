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
using CAccounts;
using Message;
using ProjectType;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for WorkWithLabs.xaml
    /// </summary>
    public partial class WorkWithLabs : Page
    {
        private bool _studentsUpdating = false;
        private bool _projectsUpdating = false;
        private CurrentWindow cw;
        private List<Student> _studentsCollection = new List<Student>();
        private Student _currentStudent;
        private List<Project> _labsCollection = new List<Project>();
        private LabWorks _currentLab;

        public WorkWithLabs()
        {
            InitializeComponent();
            cw = (App.Current as App).CurrentPage;
            DataGridTextColumn col = new DataGridTextColumn();
            col = new DataGridTextColumn();
            col.Header = "Ім'я";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("FullName");
            StudentGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Залікова книжка";
            col.Width = new DataGridLength(100);
            col.Binding = new Binding("RecordBookNumber");
            StudentGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Група";
            col.Width = new DataGridLength(100);
            col.Binding = new Binding("Group");
            StudentGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Факультет";
            col.Width = new DataGridLength(100);
            col.Binding = new Binding("Faculty");
            StudentGrid.Columns.Add(col);

            col = new DataGridTextColumn();
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
//            col = new DataGridTextColumn();
//            col.Header = "Телефон";
//            col.Width = new DataGridLength(250);
//            col.Binding = new Binding("PhoneNumber");
//            StudentGrid.Columns.Add(col);
            Projects.IsEnabled = false;
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
//            UpdateProjects();
            Events.IsEnabled = false;
            UpdateStudents();
        }

        private void UpdateStudents()
        {
            _studentsUpdating = true;
            StudentGrid.Items.Clear();
            _studentsCollection.Clear();
            foreach (var student in GetStudents())
            {
                _studentsCollection.Add(student);
                var val =
                    new StudentRow(
                        string.Format("{0} {1}. {2}.", student.Lastname, student.Firstname.Substring(0, 1),
                            student.Patronymic.Substring(0, 1)),
                        student.RBNumber, student.Group, EnumDecoder.FacultiesToString[student.Faculty.ToString()],
                        student.PhoneNumber);
                StudentGrid.Items.Add(val);
            }
            _studentsUpdating = false;
        }

        private List<Student> GetStudents()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.GET_STUDENTS;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    formatter.Serialize(writerStream, (App.Current as App).instr.InstructorId);
//                    formatter.Serialize(writerStream, EProjectType.LabWork);
                    bool flag = (bool) formatter.Deserialize(writerStream);
                    return flag ? (List<Student>) formatter.Deserialize(writerStream) : new List<Student>();
                }
            }
            catch (Exception)
            {
            }
            return new List<Student>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            TreeName.WorkWithStudents.IsExpanded = true;
        }

        private void Students_MouseDown(object sender, MouseButtonEventArgs e)
        {
//            UpdateStudents();
        }

        private void StudentGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_studentsUpdating)
                return;
            DataGrid dg = (DataGrid)sender;
            if (dg.SelectedIndex != -1)
            {
                _currentStudent = _studentsCollection[dg.SelectedIndex];
                _projectsUpdating = true;
                UpdateProjects();
                Projects.IsSelected = true;
                Projects.IsEnabled = true;
//                ProjectsGrid.SelectedIndex = 0;
                _projectsUpdating = false;
            } 
        }

        private void UpdateProjects()
        {
//            _projectsUpdating = true;
            ProjectsGrid.Items.Clear();
            _labsCollection.Clear();
            foreach (var lw in GetProjects())
            {
                var laba = (LabWorks)lw;
                _labsCollection.Add(laba);
                var val = new ProjectRow(laba.ID.ToString(), laba.Theme, laba.Description,
                    laba.Events.Count > 0 ? laba.Events[laba.Events.Count - 1].DeadLine.ToLongDateString() : String.Empty);
                ProjectsGrid.Items.Add(val);
            }
//            _projectsUpdating = false;
        }

        private List<Project> GetProjects()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.GET_PROJECT_BY_STUDENT;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    formatter.Serialize(writerStream, _currentStudent.StudentId);
                    //                    formatter.Serialize(writerStream, EProjectType.LabWork);
                    bool flag = (bool)formatter.Deserialize(writerStream);
                    return flag ? ((List<Project>)formatter.Deserialize(writerStream)).Where((pr) => pr.Type == EProjectType.LabWork).ToList() : new List<Project>();
                }
            }
            catch (Exception)
            {
            }
            return new List<Project>();
        }

        private void ProjectGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(_projectsUpdating)
                return;
            DataGrid dg = (DataGrid)sender;
            if (dg.SelectedIndex != -1)
            {
                _currentLab = (LabWorks)_labsCollection[dg.SelectedIndex];
                UpdateEvents();
                Events.IsSelected = true;
                Events.IsEnabled = true;
                EventsGrid.SelectedIndex = 0;
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
                        formatter.Serialize(writerStream, _currentLab.ID);
                        _currentLab = (LabWorks)formatter.Deserialize(writerStream);
                        if (_currentLab.ID != 0)
                        {
                            EventsGrid.Items.Clear();
                            Labname.Text = _currentLab.Theme;
                            LabSubject.Text = _currentLab.Subject;
                            LabDescription.Text = _currentLab.Description;
                            foreach (Event ev in _currentLab.Events)
                            {
                                EventsGrid.Items.Add(new EventRow(ev.SerialNumber.ToString(), ev.Title,
                                    ev.DeadLine != new DateTime() ? ev.DeadLine.ToLongDateString() : String.Empty));
                            }
//                            if (_currentLab.Events.Count != 0)
//                            {

//                                EditEvent.IsEnabled = true;
//                            }
//                            else
//                            {
//                                EditEvent.IsEnabled = false;
//                            }
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

        private void Events_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateEvents();
        }

        private void GradeButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (EventsGrid.SelectedIndex != -1)
            {
                var w = new GradeEventWindow(CurrentWindow.EditEvent, _currentLab, EventsGrid.SelectedIndex);
                w.ShowDialog();
                UpdateEvents();
                
            }
            else
                MessageBox.Show("Оберіть роботу");
        }
    }
}