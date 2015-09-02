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

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for SetDeadlinesWindow.xaml
    /// </summary>
    public partial class SetDeadlinesWindow : Window
    {
        DiplomaControlPage p;
        public SetDeadlinesWindow(CurrentWindow cw, DiplomaControlPage Page)
        {
            p = Page;
            InitializeComponent();
            if (cw == CurrentWindow.EditDeadlines)
            {
                First.SelectedDate = p.ControlDeadlines[0];
                Second.SelectedDate = p.ControlDeadlines[1];
                Third.SelectedDate = p.ControlDeadlines[2];
                if (p.ControlDeadlines.Count > 3)
                {
                    Fourth.SelectedDate = p.ControlDeadlines[3];
                    if (p.ControlDeadlines.Count > 4)
                        Fifth.SelectedDate = p.ControlDeadlines[4];
                }
                PreDefense.SelectedDate = p.PreDefenseDeadline;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (First.SelectedDate == null || Second.SelectedDate == null || Third.SelectedDate == null || PreDefense.SelectedDate == null)
                MessageBox.Show("Заповніть обов'язкові поля");
            else
            {
                p.PreDefenseDeadline = PreDefense.SelectedDate.Value;
                List<DateTime> l = new List<DateTime>();
                l.Add(First.SelectedDate.Value);
                l.Add(Second.SelectedDate.Value);
                l.Add(Third.SelectedDate.Value);
                if (Fourth.SelectedDate != null)
                {
                    l.Add(Fourth.SelectedDate.Value);
                    if (Fifth.SelectedDate != null)
                        l.Add(Fifth.SelectedDate.Value);
                }
                p.ControlDeadlines = l;
                this.Close();
            }
        }
    }
}
