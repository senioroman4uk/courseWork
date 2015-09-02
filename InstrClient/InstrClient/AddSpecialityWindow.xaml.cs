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
using Message;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AddSpecialityWindow.xaml
    /// </summary>
    public partial class AddSpecialityWindow : Window
    {
        private Speciality _speciality = new Speciality();
        private CurrentWindow _curWindow;
        public AddSpecialityWindow(CurrentWindow currentWindow, Speciality speciality = null)
        {
            _curWindow = currentWindow;
            if (_curWindow == CurrentWindow.EditSpeciality)
            {
                _speciality = speciality;
                SpecialityNameBox.Text = speciality.Name;
                SpecialityCodeBox.Text = speciality.Code;
                SpecialityCodeBox.IsReadOnly = true;
                DirectionBox.Text = speciality.Direction;
            }
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            int code;
            if (SpecialityNameBox.Text == string.Empty)
            {
                MessageBox.Show("Необхідно вказати назву спеціальності");
            }
            else if (SpecialityCodeBox.Text == string.Empty)
            {
                MessageBox.Show("Необхідно вказати код спеціальності");
            }
            else if (!Int32.TryParse(SpecialityCodeBox.Text, out code))
            {
                MessageBox.Show("Код спеціальності повинен складатися тільки з цифр");
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
                            if (_curWindow == CurrentWindow.EditSpeciality)
                            {
                                message.stat = STATUS.EDIT_SPECIALITY;
                            }
                            else
                            {
                                message.stat = STATUS.ADD_SPECIALITY;
                            }
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, new Speciality(SpecialityNameBox.Text, SpecialityCodeBox.Text, DirectionBox.Text));
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                Close();
            }
        }
    }
}
