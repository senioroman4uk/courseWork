using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for GradeEventWindow.xaml
    /// </summary>
    public partial class GradeEventWindow : Window
    {
        private Project CurPr;
        private int EventNumber;
        private CurrentWindow curWindow;
        public GradeEventWindow(CurrentWindow cw, Project pr, int evnum = 0)
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

        public GradeEventWindow()
        {
            InitializeComponent();
        }

        private void UpdateEvent_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
