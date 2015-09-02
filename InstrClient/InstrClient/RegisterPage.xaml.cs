using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CAccounts;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private bool _serverAvailable = true;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("StartPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PasswordBox.Password != PasswordRepeatBox.Password)
                    throw new Exception("Паролі не співпадають");
                Instructor instructor = new Instructor(LoginBox.Text, PasswordBox.Password, FirstNameBox.Text, LastNameBox.Text,
                    SecondNameBox.Text);
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.ADD_INSTRUCTOR;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, instructor);
                        bool fl = (bool)formatter.Deserialize(writerStream);
                        if (!fl)
                            MessageBox.Show("Помилка додавання облікового запису");
                        else
                        {
                            NavigationService nav = NavigationService.GetNavigationService(this);
                            nav.Navigate(new System.Uri("StartPage.xaml", UriKind.RelativeOrAbsolute));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Page_Initialized(object sender, RoutedEventArgs e)
        {
            if (!_serverAvailable)
            {
                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new System.Uri("StartPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
