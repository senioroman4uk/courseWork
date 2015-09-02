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
using CAccounts;
using System.Diagnostics;
using System.Windows.Navigation;

namespace AccountInfo
{
    /// <summary>
    /// Interaction logic for StudentInfoWindow.xaml
    /// </summary>
    public partial class StudentInfoWindow : Window
    {

        public StudentInfoWindow(string fullname, string group, Faculties faculty, string telephone, string email,
            string address, double averageMark)
        {
            InitializeComponent();
            PIB.Text = fullname;
            GroupText.Text = group;
            FacultyText.Text = faculty.ToString();
            TelephoneText.Text = telephone;
            EmailText.Text = email;
            Email.NavigateUri = new Uri(string.Concat("mailto:", email,
                "?subject=Лист згенеровано програмно"));
            AdressText.Text = address;
            AverageMarkText.Text = Math.Round(averageMark, 2).ToString();
        }

        private void OnNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
    }
}
