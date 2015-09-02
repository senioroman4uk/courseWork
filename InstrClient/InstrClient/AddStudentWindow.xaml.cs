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
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        private CurrentWindow cw;
        public AddStudentWindow(CurrentWindow c)
        {
            InitializeComponent();
            EducationFormBox.Items.Add("Денна");
            EducationFormBox.Items.Add("Заочна");
            EducationLevelBox.Items.Add("Бакалавр");
            EducationLevelBox.Items.Add("Магістр");
            EducationLevelBox.Items.Add("Спеціаліст");
        }
    }
}
