﻿using System;
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
using ProjectType;


// TODO переделать, добавлена ж привязка к группам и факультетам


namespace StudClient
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
            Configuration config = (App.Current as App).config;
            TcpClient eClient = new TcpClient();
            foreach (var d in (App.Current as App).GroupList)
            {
                GroupBox.Items.Add(d.Key);
            }
            foreach (var speciality in (App.Current as App).SpecialityList)
            {
                SpecialityBox.Items.Add(string.Format("{0}: {1}", speciality.Name, speciality.Code));
            }
            FacultyBox.Items.Add("ФІОТ");
            FacultyBox.Items.Add("ФЕЛ");
            FacultyBox.Items.Add("ФПМ");
            FacultyBox.Items.Add("ТЕФ");
            FacultyBox.Items.Add("РТФ");
            FacultyBox.Items.Add("ФМФ");
            FacultyBox.Items.Add("ХТФ");
            FacultyBox.Items.Add("ФСП");
            FacultyBox.Items.Add("ФММ");
            FacultyBox.Items.Add("ФЛ");
            FacultyBox.Items.Add("ФЕА");
            FacultyBox.Items.Add("ФБТ");
            FacultyBox.Items.Add("ФАКС");
            FacultyBox.Items.Add("ІФФ");
            FacultyBox.Items.Add("ПБФ"); 
            FacultyBox.Items.Add("ЗФ");
            FacultyBox.Items.Add("ІПСА");
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
                if (FacultyBox.SelectedIndex == -1)
                    throw new Exception("Факультет не вибраний");
                if (GroupBox.SelectedIndex == -1)
                    throw new Exception("Група не вибрана");
                if (PasswordBox.Password != PasswordRepeatBox.Password)
                    throw new Exception("Паролі не співпадають");
                if (SpecialityBox.SelectedIndex == -1)
                {
                    throw new Exception("Спеціальність не вибрана");
                }
                Student st = new Student(LoginBox.Text, PasswordBox.Password, FirstNameBox.Text, LastNameBox.Text,
                    SecondNameBox.Text, RecordBookBox.Text,
                    GroupBox.SelectedItem.ToString(), (Faculties) (FacultyBox.SelectedIndex + 1), string.Empty,
                    string.Empty, string.Empty, (App.Current as App).SpecialityList[SpecialityBox.SelectedIndex].Name);
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.ADD_STUDENT;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, st);
                        bool fl = (bool) formatter.Deserialize(writerStream);
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

        private void FacultyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                        var fuck = EnumDecoder.StringToFaculties[(sender as ComboBox).SelectedValue.ToString()];
                        formatter.Serialize(writerStream, fuck);
                        bool fl = (bool)formatter.Deserialize(writerStream);
                        if (!fl)
                            MessageBox.Show("Помилка зчитування групп");
                        else
                        {
                            var groups = (App.Current as App).GroupList = (Dictionary<string, int>)formatter.Deserialize(writerStream);
                            GroupBox.Items.Clear();
                            foreach (var d in groups)
                            {
                                GroupBox.Items.Add(d.Key);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
