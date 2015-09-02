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
    public class InstructorInfo
    {
        /// <summary>
        /// Показати інформацію про викладача
        /// </summary>
        /// <param name="id">Ідентифікатор в бд</param>
        [STAThreadAttribute]
        public static void ShowInstructorInfo(int id, string ip, int port)
        {
            Instructor instructor = null;
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
                    instructor = (Instructor)formatter.Deserialize(writerStream);
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

            if (instructor == null)
            {
                throw new ArgumentException(string.Format("Викладача з id = {0} не iснує", id));
            }

            InstructorInfoWindow iw = new InstructorInfoWindow(
                string.Format("{0} {1} {2}", instructor.Lastname, instructor.Firstname, instructor.Patronymic),
                instructor.Position, instructor.AcademicLevel, instructor.PhoneNumber, instructor.Email,
                instructor.Address, instructor.Workplace);
            iw.ShowDialog();
        }
    }
}