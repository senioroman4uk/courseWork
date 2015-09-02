using System;
using System.Collections.Generic;
using System.Linq;
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
using ProjectType;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Message;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AddLabWindow.xaml
    /// </summary>
    public partial class AddProjectWindow : Window
    {
        private CurrentWindow _currentWindow;
        private List<int> _studentIDCollection = new List<int>();
        private Dictionary<string, int>  _subjectsCollection = new Dictionary<string, int>();
        private Project proj;
        public AddProjectWindow(CurrentWindow cw, Project pr = null)
        {
            InitializeComponent();
            _currentWindow = cw;
            proj = pr;
            // TODO добавить для курсовіх, діпломніх
            switch (_currentWindow)
            {
                case CurrentWindow.CreateLab:
                    this.Title = "Створення лабораторних робіт";
                    GreyName.Text = "Назва лабораторної роботи";
                    break;

                case CurrentWindow.CreateRgr:
                    this.Title = "Створення РГР";
                    GreyName.Text = "Назва розрахункової роботи";
                    break;

                case CurrentWindow.EditRgr:
                    this.Title = "Редагування РГР";
                    break;
                case CurrentWindow.EditLab:
                    this.Title = "Редагування лабораторних робіт";
                    break;
            }
            if(cw == CurrentWindow.CreateLab || cw == CurrentWindow.CreateRgr)
                treeView1.ItemsSource = TreeViewModel.SetTree();
            else if (cw == CurrentWindow.EditLab || cw == CurrentWindow.EditRgr)
                treeView1.ItemsSource = TreeViewModel.SetTree(true, pr);
            Configuration config = (App.Current as App).config;
            TcpClient eClient = new TcpClient();
            try
            {
                eClient = new TcpClient(config.IP.ToString(), config.Port);
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.GET_SUBJECTS;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    bool fl = (bool)formatter.Deserialize(writerStream);
                    if (fl)
                    {
                        _subjectsCollection = (Dictionary<string, int>) formatter.Deserialize(writerStream);
                        foreach (var subject in _subjectsCollection)
                            Subject.Items.Add(subject.Key);
                    }
                   
                    else
                    {
                        // TODO возможен баг из-за закрытия в конструкторе
                        MessageBox.Show("Помилка з'єднання з сервером");
                        this.Close();
                    }
                    if (_currentWindow == CurrentWindow.EditLab || _currentWindow == CurrentWindow.EditRgr)
                    {
                        try
                        {
                            Subject.SelectedItem = proj.Subject;
                            
                        }
                        catch (Exception)
                        {
                            if(Subject.Items.Count > 0)
                                Subject.SelectedIndex = 0;
                        }
                        Name.Text = proj.Theme;
                        FlowDocument document = new FlowDocument();
                        Paragraph paragraph = new Paragraph();
                        paragraph.Inlines.Add(new Bold(new Run(proj.Description)));
                        document.Blocks.Add(paragraph);
                        Description.Document = document;
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
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text))
            {
                MessageBox.Show("Вкажіть назву роботи");
            }
            else if (string.IsNullOrEmpty(Subject.Text))
            {
                MessageBox.Show("Вкажіть предмет роботи");
            }
            else
            {
                _studentIDCollection.Clear();
                var items = treeView1.Items;
                _subjectsCollection.Clear();
                List<TreeViewModel> tvmCollection = new List<TreeViewModel>();
                foreach (TreeViewModel i in items)
                {
                    tvmCollection.Add(i);
                }
                func(tvmCollection);
                if (_studentIDCollection.Count == 0)
                    MessageBox.Show("Не обрано студентів");
                else if(_currentWindow == CurrentWindow.EditLab || _currentWindow == CurrentWindow.CreateLab)
                {
                    LabWorks labWork = new LabWorks((App.Current as App).instr.InstructorId, 0, Name.Text,
                        new TextRange(Description.Document.ContentStart, Description.Document.ContentEnd).Text);
                    labWork.Subject = Subject.SelectedItem.ToString();
                    if (_currentWindow == CurrentWindow.EditLab)
                    {
                        labWork.ID = proj.ID;
                        labWork.InstructorId = proj.InstructorId;
                        labWork.Events = proj.Events;
                        labWork.ParentProjectId = 0;
                    }
                    Configuration config = (App.Current as App).config;
                    TcpClient eClient = new TcpClient();
                    try
                    {
                        eClient = new TcpClient(config.IP.ToString(), config.Port);
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            if (_currentWindow == CurrentWindow.CreateLab)
                                message.stat = STATUS.CREATE_LABS;
                            else if (_currentWindow == CurrentWindow.EditLab)
                                message.stat = STATUS.EDIT_LABS;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, labWork);
                            formatter.Serialize(writerStream, _studentIDCollection);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (!fl)
                            {
                                // TODO создать диалог да нет на выбор выйти или повторить
                                MessageBox.Show("Помилка додавання/редагування лабораторних робіт");
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
                else if (_currentWindow == CurrentWindow.EditRgr || _currentWindow == CurrentWindow.CreateRgr)
                {
                    RGR rgr = new RGR((App.Current as App).instr.InstructorId, 0, Name.Text,
                        new TextRange(Description.Document.ContentStart, Description.Document.ContentEnd).Text);
                    rgr.Subject = Subject.SelectedItem.ToString();
                    if (_currentWindow == CurrentWindow.EditRgr)
                    {
                        rgr.ID = proj.ID;
                        rgr.InstructorId = proj.InstructorId;
                        rgr.Events = proj.Events;
                        rgr.ParentProjectId = 0;
                    }
                    Configuration config = (App.Current as App).config;
                    TcpClient eClient = new TcpClient();
                    try
                    {
                        eClient = new TcpClient(config.IP.ToString(), config.Port);
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            if (_currentWindow == CurrentWindow.CreateRgr)
                                message.stat = STATUS.CREATE_RGR;
                            else if (_currentWindow == CurrentWindow.EditRgr)
                                message.stat = STATUS.EDIT_RGR;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, rgr);
                            formatter.Serialize(writerStream, _studentIDCollection);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (!fl)
                            {
                                // TODO создать диалог да нет на выбор выйти или повторить
                                MessageBox.Show("Помилка додавання/редагування РГР");
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

        private void func(List<TreeViewModel> groupNameCollection)
        {
            foreach (var groupName in groupNameCollection)
            {
                foreach (var student in groupName.Children)
                    if (student.IsChecked == true)
                        _studentIDCollection.Add(student.ID);
            }
        }

        private void Not_OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
