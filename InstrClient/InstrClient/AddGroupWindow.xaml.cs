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
    /// Interaction logic for AddGroupWindow.xaml
    /// </summary>
    public partial class AddGroupWindow : Window
    {
        private CurrentWindow _cw;
        private string _oldGroupName;
        private string _oldFaculty;

        public AddGroupWindow(CurrentWindow windowMode, string groupName = "", string facultyName = "")
        {
            InitializeComponent();
            _cw = windowMode;
            _oldGroupName = groupName;
            _oldFaculty = facultyName;
            this.Title = _cw == CurrentWindow.AddGroup ? "Створення групи" : "Редагування групи";
            foreach (var faculty in EnumDecoder.StringToFaculties)
            {
                FacultyBox.Items.Add(faculty.Key);
            }
            InitializeComponent();
            if (_cw == CurrentWindow.EditGroup)
            {
                GroupNameBox.Text = groupName;
                FacultyBox.SelectedItem = facultyName;
            }
            else if(FacultyBox.Items.Count >= 0)
            {
                FacultyBox.SelectedIndex = 0;
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GroupNameBox.Text))
            {
                MessageBox.Show("Потрібно вказати назву группи");
            }
            else if (string.IsNullOrEmpty(FacultyBox.Text))
            {
                MessageBox.Show("Потрібно вказати факультет");
            }
            else
            {
                if (_cw == CurrentWindow.EditGroup && _oldGroupName == GroupNameBox.Text && _oldFaculty == FacultyBox.Text)
                {
                    this.Close();
                }
                else
                {

                    Configuration config = (App.Current as App).config;
                    TcpClient eClient = new TcpClient();
                    try
                    {
                        eClient = new TcpClient(config.IP.ToString(), config.Port);
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = _cw == CurrentWindow.AddGroup ? STATUS.ADD_GROUP : STATUS.EDIT_GROUP;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            if (_cw == CurrentWindow.EditGroup)
                            {
                                formatter.Serialize(writerStream, _oldGroupName);
                            }
                            formatter.Serialize(writerStream, GroupNameBox.Text);
                            if (_cw == CurrentWindow.AddGroup)
                            {
                                formatter.Serialize(writerStream, EnumDecoder.StringToFaculties[FacultyBox.Text]);   
                            }
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (!fl)
                            {
                                MessageBox.Show("Група вже існує", string.Concat("Помилка ",
                                    _cw == CurrentWindow.AddGroup ? "додавання" : "редагування", " групи"), MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        eClient.Close();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
