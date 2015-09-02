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
using System.Windows.Shapes;
using CAccounts;
using ProjectType;
using System.Text.RegularExpressions;
using Message;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AddEventWindow.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        private Project CurPr;
        private int EventNumber;
        private CurrentWindow curWindow;
        public AddEventWindow(CurrentWindow cw, Project pr, int evnum = 0)
        {
            curWindow = cw;
            InitializeComponent();
            DeadlineDate.SelectedDate = DateTime.Today;
            CurPr = pr;
            SerialNumber.Text = (CurPr.Events.Count + 1).ToString();
            if (cw == CurrentWindow.AddEvent)
            {
                OK.Content = "Додати";
                FileControl.IsEnabled = false;
            }
            else
            {
                EventNumber = evnum;
                OK.Content = "Зберегти";
                DeadlineDate.SelectedDate = CurPr.Events[EventNumber].DeadLine;
                Name.Text = CurPr.Events[EventNumber].Title;
                Description.Text = CurPr.Events[EventNumber].Description;
                SerialNumber.Text = CurPr.Events[EventNumber].SerialNumber.ToString();
            }
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(SerialNumber.Text) < 1 || int.Parse(SerialNumber.Text) > CurPr.Events.Count + 1)
            {
                MessageBox.Show(string.Format("Порядковий номер івента повинен бути менше {0} і більше 0.",
                    CurPr.Events.Count + 2));
            }
            else if (Name.Text == string.Empty)
                MessageBox.Show("Необхідно вказати заголовок");
            else 
            {
                Event ev = new Event(CurPr.ID, int.Parse(SerialNumber.Text), Name.Text, 
                    DeadlineDate.SelectedDate == null ? DateTime.Now : DeadlineDate.SelectedDate.Value, Description.Text);
                try
                {
                    Configuration config = (App.Current as App).config;
                    using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                    {
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            if(curWindow == CurrentWindow.AddEvent)
                                message.stat = STATUS.ADD_EVENT;
                            else if (curWindow == CurrentWindow.EditEvent)
                            {
                                ev.ID = CurPr.Events[EventNumber].ID;
                                message.stat = STATUS.UPDATE_EVENT;
                            }
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, ev);
                            if (!(bool)formatter.Deserialize(writerStream))
                                MessageBox.Show("Помилка обробки івенту");
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Помилка обробки івенту");
                }   
            }
        }
        private void Not_OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void FileControl_Click(object sender, RoutedEventArgs e)
        {
            FileControlWindow fcw = new FileControlWindow(CurPr.Events[EventNumber].ID);
            fcw.ShowDialog();
        }
    }
}
