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
    /// Interaction logic for GroupControlPage.xaml
    /// </summary>
    public partial class GroupControlPage : Page
    {
        private CurrentWindow cw;
        private Dictionary<GroupRow, int> _groupsCollection = new Dictionary<GroupRow, int>();
        public GroupControlPage()
        {
            InitializeComponent();
            cw = (App.Current as App).CurrentPage;
            DataGridTextColumn col = new DataGridTextColumn();
            col = new DataGridTextColumn();
            col.Header = "Група";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("Name");
            GroupGrid.Columns.Add(col); col = new DataGridTextColumn();
            col.Header = "Факультет";
            col.Width = new DataGridLength(250);
            col.Binding = new Binding("Faculty");
            GroupGrid.Columns.Add(col);
            UpdateGroups();
        }

        private void UpdateGroups()
        {
            GroupGrid.Items.Clear();
            _groupsCollection.Clear();
            foreach (var group in InitGroupTable())
            {
                GroupGrid.Items.Add(group.Key);
            }
        }

        public Dictionary<GroupRow, int> InitGroupTable()
        {
            _groupsCollection.Clear();
            foreach (var faculty in EnumDecoder.StringToFaculties)
            {
                try
                {
                    Configuration config = (App.Current as App).config;
                    using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                    {
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.GET_GROUP_BY_FACULTY;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message); 
                            formatter.Serialize(writerStream, faculty.Value);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (fl)
                            {
                                foreach (var group in (Dictionary<string, int>)formatter.Deserialize(writerStream))
                                {
                                    _groupsCollection.Add(new GroupRow(group.Key, faculty.Key), group.Value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return _groupsCollection;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.Administration.IsExpanded = true;
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            AddGroupWindow w = new AddGroupWindow(CurrentWindow.AddGroup);
            w.ShowDialog();
            UpdateGroups();
        }

        private void EditGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GroupGrid.SelectedIndex >= 0)
            {
                AddGroupWindow w = new AddGroupWindow(CurrentWindow.EditGroup, _groupsCollection.ElementAt(GroupGrid.SelectedIndex).Key.Name,
                    _groupsCollection.ElementAt(GroupGrid.SelectedIndex).Key.Faculty);
                w.ShowDialog();
                UpdateGroups();
            }
            else
            {
                MessageBox.Show("Оберіть групу");
            }
        }

        private void DeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GroupGrid.SelectedIndex >= 0)
            {
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.DELETE_GROUP;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, _groupsCollection.ElementAt(GroupGrid.SelectedIndex).Value);
                        bool fl = (bool)formatter.Deserialize(writerStream);
                        if (!fl)
                        {
                            MessageBox.Show("Помилка видалення групи");
                        }
                        else
                        {
                            UpdateGroups();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            else
            {
                MessageBox.Show("Оберіть групу");
            }
        }
    }
    public class GroupRow
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public GroupRow() { }

        public GroupRow(string name, string faculty)
        {
            Name = name;
            Faculty = faculty;
        }
    }
}
