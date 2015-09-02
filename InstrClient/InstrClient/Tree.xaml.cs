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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for Tree.xaml
    /// </summary>
    public partial class Tree : UserControl
    {
        public Tree()
        {
            InitializeComponent();
        }
        private void LabControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.LabControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("LabControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void RGRControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.RGRControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("RGRControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void CourseControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.CourseControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("CourseControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void DiplomaControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.DiplomaControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("DiplomaControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void SubjectControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.SubjectControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("SubjectControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void GroupControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.GroupControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("GroupControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void StudentControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.StudentControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("StudentControlPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void SpecialityControl_Selected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.StudentControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("SpecialityControlPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void WorkWithLabs_OnSelected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.LabControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("WorkWithLabs.xaml", UriKind.RelativeOrAbsolute));
        }

        private void WorkWithRgr_OnSelected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.LabControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("WorkWithRgr.xaml", UriKind.RelativeOrAbsolute));
        }

        private void WorkWithCourseProject_OnSelected(object sender, RoutedEventArgs e)
        {
            (App.Current as App).CurrentPage = CurrentWindow.LabControl;
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new System.Uri("WorkWithCourseProject.xaml", UriKind.RelativeOrAbsolute));
        }

        private void WorkWithDiploma_OnSelected(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
