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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CAccounts;
using Message;
using ProjectType;

namespace InstrClient
{
    /// <summary>
    /// Interaction logic for SpecialityControlPage.xaml
    /// </summary>
    public partial class SpecialityControlPage : Page
    {
        private List<Speciality> _specialityCollection = new List<Speciality>();

        public SpecialityControlPage()
        {
            InitializeComponent();
            DataGridTextColumn col = new DataGridTextColumn();
            col = new DataGridTextColumn();
            col.Header = "Назва спеціальності";
            col.Width = new DataGridLength(350);
            col.Binding = new Binding("Name");
            SpecialityGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Код";
            col.Width = new DataGridLength(150);
            col.Binding = new Binding("Code");
            SpecialityGrid.Columns.Add(col);
            col = new DataGridTextColumn();
            col.Header = "Напрям";
            col.Width = new DataGridLength(150);
            col.Binding = new Binding("Direction");
            SpecialityGrid.Columns.Add(col);
            UpdateSpecialities();
        }

        private void UpdateSpecialities()
        {
            SpecialityGrid.Items.Clear();
            try
            {
                Configuration config = (App.Current as App).config;
                using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                {
                    using (NetworkStream writerStream = eClient.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_SPECIALITIES;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        if ((bool)formatter.Deserialize(writerStream))
                        {
                            _specialityCollection = (List<Speciality>)formatter.Deserialize(writerStream);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            foreach (var speciality in _specialityCollection)
            {
                SpecialityGrid.Items.Add(speciality);
            }
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TreeName.Administration.IsExpanded = true;
        }

        private void AddSpeciality_Click(object sender, RoutedEventArgs e)
        {
            AddSpecialityWindow asw = new AddSpecialityWindow(CurrentWindow.AddSpeciality);
            asw.ShowDialog();
            UpdateSpecialities();
        }

        private void EditSpeciality_Click(object sender, RoutedEventArgs e)
        {
            int index = SpecialityGrid.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Оберіть спеціальність для редагування");
            }
            else
            {
                AddSpecialityWindow asw = new AddSpecialityWindow(CurrentWindow.EditSpeciality, _specialityCollection[index]);
                asw.ShowDialog();   
            }
        }

        private void DeleteSpeciality_Click(object sender, RoutedEventArgs e)
        {
            int index = SpecialityGrid.SelectedIndex;
            int code;
            if (index < 0)
            {
                MessageBox.Show("Оберіть спеціальність");
            }
            else if (!Int32.TryParse(_specialityCollection[index].Code, out code))
            {
                MessageBox.Show("Невірний код спеціальності", "Помилка видалення");
            }
            else
            {
                try
                {
                    Configuration config = (App.Current as App).config;
                    using (TcpClient eClient = new TcpClient(config.IP.ToString(), config.Port))
                    {
                        using (NetworkStream writerStream = eClient.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.DELETE_SPECIALITY;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, code);
                            string result = (string)formatter.Deserialize(writerStream);
                            if (!string.IsNullOrEmpty(result))
                            {
                                MessageBox.Show(result);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                UpdateSpecialities();
            }
        }
    }
}
