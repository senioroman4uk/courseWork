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
    /// Interaction logic for StudentWorkPage.xaml
    /// </summary>

    public partial class StudentWorkPage : Page
    {
        List<Student> students = new List<Student>();
        private Student _currentStudent;
        private EProjectType _type = EProjectType.Undefined;

        public StudentWorkPage()
        {
            InitializeComponent();

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
            col.Header = "Тема роботи";
            col.Width = new DataGridLength(100);
            col.Binding = new Binding("Theme");
            StudentGrid.Columns.Add(col);

        }

        

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TreeName.WorkWithStudents.IsExpanded = true;
                if (Application.Current.Properties.Contains("NodeHeader"))
                {
                    switch (Application.Current.Properties["NodeHeader"] as string)
                    {
                        case "Лабораторні роботи":
                            _type = EProjectType.LabWork;
                            break;
                        case "Розрахунково-графічні роботи":
                            _type = EProjectType.Rgr;
                            break;
                        case "Курсові роботи":
                            _type = EProjectType.CourseWork;
                            break;
                        case "Дипломні роботи":
                            _type = EProjectType.DiplomaProject;
                            break;
                        default:
                            throw new ArgumentException("Невірно обрано тип проету");
                    }
                    UpdateStudentsGrid();
                }
            }
            finally
            {
                if (Application.Current.Properties.Contains("NodeHeader"))
                    Application.Current.Properties.Remove("NodeHeader");
            }
            
        }

        private void UpdateStudentsGrid()
        {
            StudentGrid.Items.Clear();
            students.Clear();
            foreach (var student in GetStudents())
            {
                students.Add(student);
                var row = new StudentRow(string.Format("{0} {1}. {2}.", student.Lastname, student.Firstname.Substring(0, 1),
                            student.Patronymic.Substring(0, 1)),
                        student.RBNumber, student.Group, EnumDecoder.FacultiesToString[student.Faculty.ToString()], "");
                StudentGrid.Items.Add(row);
            }
        }

        private List<Student> GetStudents()
        {
            Configuration config = (App.Current as App).config;
            using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
            using (NetworkStream writerStream = eClient.GetStream())
            {
                MSG message = new MSG(){stat = STATUS.GET_STUDENTS_BY_INSTRUCTORID_PROJECT_TYPE};
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writerStream, message);
                formatter.Serialize(writerStream, (App.Current as App).instr.InstructorId);
                formatter.Serialize(writerStream, _type);
                bool flag = (bool) formatter.Deserialize(writerStream);
                return flag ? (List<Student>)formatter.Deserialize(writerStream) : new List<Student>();
            }
        }

        private void Students_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateStudentsGrid();
        }

        private void StudentsGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
