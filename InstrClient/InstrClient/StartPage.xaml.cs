﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CAccounts;
using Message;
using ProjectType;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            (App.Current as App).CreateConfig();
            Configuration cn = (App.Current as App).config;
            InitializeComponent();
            if (cn.Login != null)
                LoginBox.Text = cn.Login;
            if (cn.Password != null)
                PasswordBox.Password = cn.Password;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Configuration config = (App.Current as App).config;
            TcpClient eClient = new TcpClient();
            try
            {
                eClient = new TcpClient(config.IP.ToString(), config.Port);
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.LOGIN;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    formatter.Serialize(writerStream, LoginBox.Text);
                    formatter.Serialize(writerStream, PasswordBox.Password);
                    bool fl = (bool)formatter.Deserialize(writerStream);
                    if (fl)
                    {
                        Account ac = (Account)formatter.Deserialize(writerStream);
                        if (ac != null)
                        {
                            Instructor st;
                            if (ac is Instructor)
                            {
                                st = (Instructor)ac;
                                config.Login = LoginBox.Text;
                                config.Password = PasswordBox.Password;
                                (App.Current as App).SaveConfig();
                                (App.Current as App).instr = st;
                                NavigationService nav = NavigationService.GetNavigationService(this);
                                nav.Navigate(new System.Uri("MainWindow.xaml", UriKind.RelativeOrAbsolute));
                            }
                            else
                            {
                                MessageBox.Show("Невірний тип облікового запису");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невірна комбінація");
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

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("RegisterPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
