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
    /// Interaction logic for DiplomaControlPage.xaml
    /// </summary>
    public partial class DiplomaControlPage : Page
    {
        public List<DateTime> ControlDeadlines;
        public DateTime PreDefenseDeadline;
        DiplomaRow Diploma;
        public DiplomaControlPage()
        {
            InitializeComponent();
            ControlDeadlines = new List<DateTime>();
            ControlDeadlines.Add(new DateTime(2015, 5, 28));
            ControlDeadlines.Add(new DateTime(2015, 5, 29));
            ControlDeadlines.Add(new DateTime(2015, 5, 30));
            PreDefenseDeadline = new DateTime(2015, 5, 31);

            // PracticeGrid
            DataGridTextColumn col = new DataGridTextColumn();
            col.Header = "Номер заліковки";
            col.Width = new DataGridLength(110);
            col.Binding = new Binding("RecordBookNumber");
            PracticeGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "ПІБ";
            col.Width = new DataGridLength(240);
            col.Binding = new Binding("FullName");
            PracticeGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Група";
            col.Width = new DataGridLength(70);
            col.Binding = new Binding("Group");
            PracticeGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Звіт";
            col.Width = new DataGridLength(40);
            col.Binding = new Binding("PracticeReport");
            PracticeGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "ECTS";
            col.Width = new DataGridLength(40);
            col.Binding = new Binding("PracticeECTS");
            PracticeGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Бали";
            col.Width = new DataGridLength(40);
            col.Binding = new Binding("PracticePoints");
            PracticeGrid.Columns.Add(col);

            // ProjectingGrid
            col = new DataGridTextColumn();
            col.Header = "Номер заліковки";
            col.Width = new DataGridLength(110);
            col.Binding = new Binding("RecordBookNumber");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "ПІБ";
            col.Width = new DataGridLength(240);
            col.Binding = new Binding("FullName");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Група";
            col.Width = new DataGridLength(70);
            col.Binding = new Binding("Group");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Заява";
            col.Width = new DataGridLength(45);
            col.Binding = new Binding("Application");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "ПЗ";
            col.Width = new DataGridLength(30);
            col.Binding = new Binding("PZ");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Відгук";
            col.Width = new DataGridLength(45);
            col.Binding = new Binding("Response");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Рецензент";
            col.Width = new DataGridLength(240);
            col.Binding = new Binding("Reviewer");
            ProjectingGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Рецензія";
            col.Width = new DataGridLength(60);
            col.Binding = new Binding("Review");
            ProjectingGrid.Columns.Add(col);

            Diploma = new DiplomaRow("IS-3204", "Lol Lol Lol", "IS-32", "90", "1.06.2015", "10", "30", "50", "", "", "+", "E", "60", "+", "-", "-", "Lohovskiy Loh Lohovich", "+");
            PracticeGrid.Items.Add(Diploma);
            ProjectingGrid.Items.Add(Diploma);
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.ProjectControl.IsExpanded = true;
        }

        private void SetDeadlines_Click(object sender, RoutedEventArgs e)
        {
            SetDeadlinesWindow sdw = new SetDeadlinesWindow(CurrentWindow.SetDeadlines, this);
            sdw.ShowDialog();
        }

        private void ChangeDeadlines_Click(object sender, RoutedEventArgs e)
        {
            SetDeadlinesWindow sdw = new SetDeadlinesWindow(CurrentWindow.EditDeadlines, this);
            sdw.ShowDialog();
        }
        private void DiplomaTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DiplomaTabs.SelectedIndex == 2)
            {
                JournalGrid.Columns.Clear();
                JournalGrid.Items.Clear();
                DataGridTextColumn col = new DataGridTextColumn();
                col.Header = "Номер заліковки";
                col.Width = new DataGridLength(110);
                col.Binding = new Binding("RecordBookNumber");
                JournalGrid.Columns.Add(col);
                col = new DataGridTextColumn();
                col.Header = "ПІБ";
                col.Width = new DataGridLength(240);
                col.Binding = new Binding("FullName");
                JournalGrid.Columns.Add(col);
                for (int i = 0; i < ControlDeadlines.Count; i++)
                {
                    col = new DataGridTextColumn();
                    col.Header = "Контроль " + (i + 1) + ": " + ControlDeadlines[i].ToShortDateString();
                    col.Width = new DataGridLength(150);
                    col.Binding = new Binding("Date" + (i + 1));
                    JournalGrid.Columns.Add(col);
                }
                col = new DataGridTextColumn();
                col.Header = "Передзахист: " + PreDefenseDeadline.ToShortDateString();
                col.Width = new DataGridLength(150);
                col.Binding = new Binding("PreDefense");
                JournalGrid.Columns.Add(col);
                col = new DataGridTextColumn();
                col.Header = "Захист (дата)";
                col.Width = new DataGridLength(80);
                col.Binding = new Binding("DefenseDate");
                JournalGrid.Columns.Add(col);
                JournalGrid.Items.Add(Diploma);
            }
        }
    }
}
