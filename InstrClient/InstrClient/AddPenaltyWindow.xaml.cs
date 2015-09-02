using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
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
using ProjectType;
using System.Text.RegularExpressions;
using Message;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for AddPenaltyWindow.xaml
    /// </summary>
    public partial class AddPenaltyWindow : Window
    {
        private Project CurPr;
        private int EventNumber;
        private CurrentWindow curWindow;
        public AddPenaltyWindow(Project cp, int evnum, CurrentWindow cw)
        {
            CurPr = cp;
            EventNumber = evnum;
            curWindow = cw;
            InitializeComponent();
            if (curWindow == CurrentWindow.AddPenalty)
            {
                this.Title = "Додати штраф";
            }
            else
            {
                this.Title = "Редагувати штраф";
            }
        }

        private void ModeCheck_Checked(object sender, RoutedEventArgs e)
        {
            ValueCheck.IsEnabled = false;
            ValueBox.IsEnabled = false;
        }

        private void ValueCheck_Checked(object sender, RoutedEventArgs e)
        {
            ModeCheck.IsEnabled = false;
            ModeBox.IsEnabled = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (PenaltyDescriptionBox.Text == "")
            {
                MessageBox.Show("Введіть опис штрафу");
            }
            else
            {
                int mode;
                double val;
                if (ModeCheck.IsChecked == true)
                {
                    try
                    {
                        mode = int.Parse(ModeBox.Text);
                        if (mode < 1 || mode > 100)
                            throw (new Exception());

                        // Добавить штраф

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Введіть ціле число від 1 до 100");
                    }
                }
                else if (ValueCheck.IsChecked == true)
                {
                    try
                    {
                        val = double.Parse(ValueBox.Text);

                        //Добавить штраф

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Введіть дробове число");
                    }
                }
                else
                {
                    MessageBox.Show("Виберіть тип штрафу");
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ModeCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            ValueCheck.IsEnabled = true;
            ValueBox.IsEnabled = true;
        }

        private void ValueCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            ModeCheck.IsEnabled = true;
            ModeBox.IsEnabled = true;
        }
    }
}
