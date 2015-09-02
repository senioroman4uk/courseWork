using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using Message;
using Microsoft.Win32;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for FileControlWindow.xaml
    /// </summary>
    public partial class FileControlWindow : Window
    {
        private int _eventId;
        private Dictionary<string, string> _files = new Dictionary<string,string>();
        public FileControlWindow(int eventId)
        {
            _eventId = eventId;
            InitializeComponent();
            DataGridTextColumn col = new DataGridTextColumn();
            col.Header = "Назва файлу";
            col.Width = new DataGridLength(140);
            col.Binding = new Binding("FileName");
            FilesGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Відправник";
            col.Width = new DataGridLength(140);
            col.Binding = new Binding("Sender");
            FilesGrid.Columns.Add(col);
            ReReadFiles();
        }


        private void ReReadFiles()
        {
            FilesGrid.Items.Clear();
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_FILES;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, _eventId);
                        formatter.Serialize(writerStream, false);
                        _files = (Dictionary<string, string>)formatter.Deserialize(writerStream);
                        foreach (var file in _files)
                        {
                            FilesGrid.Items.Add(new FileRow(file.Key, "Викладач"));
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Помилка додавання файлу");
            }
        }

        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Multiselect = true;
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openDialog.ShowDialog() == true)
            {
                try
                {
                    Configuration config = (App.Current as App).config;
                    using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                    {
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.ADD_FILE;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, 0);
                            formatter.Serialize(writerStream, _eventId);
                            formatter.Serialize(writerStream, openDialog.FileNames.Length);
                            foreach (var fileName in openDialog.FileNames)
                            {
                                if (fileName != null)
                                {
                                    formatter.Serialize(writerStream, System.IO.Path.GetFileName(fileName));
                                    formatter.Serialize(writerStream, File.ReadAllBytes(fileName));
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Помилка додавання файлу");
                }
                ReReadFiles();
            }
        }


        private void DeleteFile_Click(object sender, RoutedEventArgs e)
        {
            int index = FilesGrid.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Оберіть файл");
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
                            message.stat = STATUS.DELETE_FILE;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, _eventId);
                            formatter.Serialize(writerStream, FilesGrid.SelectedItems.Count);
                            foreach (var item in FilesGrid.SelectedItems)
                            {
                                formatter.Serialize(writerStream, _files[((FileRow)item).FileName]);
                            }
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (!fl)
                            {
                                MessageBox.Show("Помилка видалення файлу");
                            }
                            ReReadFiles();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Помилка видалення файлу");
                }
            }
        }


        private class FileRow
        {
            public string FileName { get; set; }
            public string Sender { get; set; }
            
            public FileRow() { }

            public FileRow(string fileName, string sender)
            {
                FileName = fileName;
                Sender = sender;
            }
        }
    }
}
