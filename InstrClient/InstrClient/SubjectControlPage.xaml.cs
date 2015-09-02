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

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AdministrationPage.xaml
    /// </summary>
    public partial class SubjectControlPage : Page
    {
        private CurrentWindow cw;
        private Dictionary<string, int> _subjectsCollection = new Dictionary<string, int>();
        public SubjectControlPage()
        {
            InitializeComponent();
            cw = (App.Current as App).CurrentPage;
            DataGridTextColumn col = new DataGridTextColumn();
            col = new DataGridTextColumn();
            col.Header = "Назва";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("Name");
            SubjectGrid.Columns.Add(col); 
            UpdateSubjects();
        }

        private void UpdateSubjects()
        {
            SubjectGrid.Items.Clear();
            _subjectsCollection.Clear();
            foreach (var group in InitSubjectsTable())
            {
                var val = new SubjectRow(group.Key);
                SubjectGrid.Items.Add(val);
            }
        }

        public Dictionary<string, int> InitSubjectsTable()
        {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_SUBJECTS;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        bool fl = (bool)formatter.Deserialize(writerStream);
                        if (fl)
                        {
                            _subjectsCollection = (Dictionary<string, int>)formatter.Deserialize(writerStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return _subjectsCollection;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.Administration.IsExpanded = true;
        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            AddSubjectWindow w = new AddSubjectWindow(CurrentWindow.AddSubject);
            w.ShowDialog();
            UpdateSubjects();
        }

        private void EditEvent_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectGrid.SelectedIndex >= 0)
            {
            AddSubjectWindow w = new AddSubjectWindow(CurrentWindow.EditSubject, _subjectsCollection.ElementAt(SubjectGrid.SelectedIndex).Value,
                _subjectsCollection.ElementAt(SubjectGrid.SelectedIndex).Key);
            w.ShowDialog();
            UpdateSubjects();
        }
            else
            {
                MessageBox.Show("Оберіть предмет");
            }
        }

        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectGrid.SelectedIndex >= 0)
            {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.DELETE_SUBJECT;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, _subjectsCollection.ElementAt(SubjectGrid.SelectedIndex).Value);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                        if (!fl)
                        {
                            MessageBox.Show("Помилка видалення предмета");
                        }
                        else
                        {
                            UpdateSubjects();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Оберіть предмет");
            }
        }
    }
    public class SubjectRow
    {
        public string Name { get; set; }
        public SubjectRow() { }

        public SubjectRow(string name)
        {
            Name = name;
        }
    }
}
