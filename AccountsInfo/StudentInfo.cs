using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAccounts;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using Message;

namespace AccountInfo
{
    public class StudentInfo
    {
        /// <summary>
        /// Показати інформацію про студента
        /// </summary>
        /// <param name="id">Ідентифікатор в бд</param>
        [STAThreadAttribute]
        public static void ShowStudentInfo(int id, string ip, int port)
        {
            Student student = null;
            TcpClient eClient = new TcpClient();
            try
            {
                eClient = new TcpClient(ip, port);
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.GET_ACCOUNT_BY_ID;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    formatter.Serialize(writerStream, id);
                    student = (Student)formatter.Deserialize(writerStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                eClient.Close();
            }

            if (student == null)
            {
                throw new ArgumentException(string.Format("Студента з id = {0} не iснує", id));
            }

            StudentInfoWindow sw = new StudentInfoWindow(string.Format("{0} {1} {2}", student.Lastname, student.Firstname, student.Patronymic),
                student.Group, student.Faculty, student.PhoneNumber, student.Email, student.Address, student.AverageMark);
            sw.ShowDialog();
        }
    }
}