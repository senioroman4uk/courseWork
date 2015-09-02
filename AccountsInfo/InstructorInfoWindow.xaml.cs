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
    /// Interaction logic for InstructorInfoWindow.xaml
    /// </summary>
    public partial class InstructorInfoWindow : Window
    {
        public InstructorInfoWindow(string fullname, string profession, string academicLevel, string telephone,
            string email, string address, string workplace)
        {
            InitializeComponent();
            PIB.Text = fullname;
            Profession.Text = profession;
            AcLevel.Text = academicLevel;
            TelephoneText.Text = telephone;
            EmailText.Text = email;
            Email.NavigateUri = new Uri(string.Concat("mailto:", email,
                "?subject=Лист згенеровано програмно"));
            AdressText.Text = address;
            WorkPlace.Text = workplace;
        }

        private void OnNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
    }
}
