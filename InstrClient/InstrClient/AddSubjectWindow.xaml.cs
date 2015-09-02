using System;
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
using System.Windows.Shapes;
using Message;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AddSubjectWindow.xaml
    /// </summary>
    public partial class AddSubjectWindow : Window
    {
        private CurrentWindow _cw;
        private int _subjectId;
        private string _oldSubjectName;
        public AddSubjectWindow(CurrentWindow currentWindow, int subjectId = 0, string subjectName = "")
        {
            _cw = currentWindow;
            _subjectId = subjectId;
            this.Title = _cw == CurrentWindow.AddSubject ? "Створення предмета" : "Редагування предмета";
            InitializeComponent();
            if (_cw == CurrentWindow.EditSubject)
                SubjectNameBox.Text = _oldSubjectName = subjectName;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SubjectNameBox.Text))
                MessageBox.Show("Потрібно вказати назву предмета");
            else
            {
                if (_cw == CurrentWindow.EditSubject && _oldSubjectName == SubjectNameBox.Text)
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
                            message.stat = _cw == CurrentWindow.AddSubject ? STATUS.ADD_SUBJECT : STATUS.EDIT_SUBJECT;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, SubjectNameBox.Text);
                            if (_cw == CurrentWindow.EditSubject)
                                formatter.Serialize(writerStream, _subjectId);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (!fl)
                            {
                                MessageBox.Show("Предмет вже існує", string.Concat("Помилка ",
                                    _cw == CurrentWindow.AddSubject ? "додавання" : "редагування", " предмета"), MessageBoxButton.OK,
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
