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

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for StudentControlPage.xaml
    /// </summary>
    public partial class StudentControlPage : Page
    {
        private CurrentWindow cw;
        private List<Student> _studentsCollection = new List<Student>(); 
        public StudentControlPage()
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
            col.Header = "Телефон";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("PhoneNumber");
            StudentGrid.Columns.Add(col);
            UpdateStudents();
        }

        void UpdateStudents()
        {
            StudentGrid.Items.Clear();
            _studentsCollection.Clear();
            foreach (var student in InitStudentTable())
            {
                var val =
                    new StudentRow(
                        string.Format("{0} {1}. {2}.", student.Lastname, student.Firstname.Substring(0, 1),
                            student.Patronymic.Substring(0, 1)),
                        student.RBNumber, student.Group, EnumDecoder.FacultiesToString[student.Faculty.ToString()], student.PhoneNumber);
                StudentGrid.Items.Add(val);
            }
        }

        public List<Student> InitStudentTable()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_STUDENTS;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, (App.Current as App).instr.InstructorId);
                        bool fl = (bool)formatter.Deserialize(writerStream);
                        if (fl)
                        {
                            _studentsCollection = (List<Student>)formatter.Deserialize(writerStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return _studentsCollection;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.Administration.IsExpanded = true;
        }

        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow w = new AddStudentWindow(CurrentWindow.EditStudent);
            w.ShowDialog();
        }
    }
    public class StudentRow
    {
        public string FullName { get; set; }
        public string RecordBookNumber { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string PhoneNumber{ get; set; }
        public StudentRow() { }

        public StudentRow(string name, string recordBookNumber, string group, string faculty, string phoneNumber)
        {
            FullName = name;
            RecordBookNumber = recordBookNumber;
            Group = group;
            Faculty = faculty;
            PhoneNumber = phoneNumber;
        }
    }
}
