using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CAccounts;
using Message;
using ProjectType;
using DataBaseUtilities;

namespace ServerV1
{
    public partial class Form1 : Form
    {
        public TcpListener listener;
        public Thread thread_listener;
        public Configuration config;         
        private void listen()
        {
            try
            {
                listener.Start();
                while (true)
                {
                    ClientHandler handler = new ClientHandler(listener.AcceptTcpClient(), this);
                    Thread clientThread = new Thread(new ThreadStart(handler.RunClient));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }

            }
            catch (Exception exp)
            {

            }
        }

        public Form1()
        {
            if (File.Exists("config.bin"))
            {
                FileStream fs = new FileStream("config.bin", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                config = (Configuration) formatter.Deserialize(fs);
                fs.Close();
            }
            else
                config = new Configuration();
            listener = new TcpListener(config.get_ip(), config.get_port());
            InitializeComponent();
            bServerStop.Enabled = false;
        }

        private void bServerStart_Click(object sender, EventArgs e)
        {
            thread_listener = new Thread(new ThreadStart(listen));
            thread_listener.Start();
            bServerStart.Enabled = false;
            bServerStop.Enabled = true;            
        }
        private void bServerStop_Click(object sender, EventArgs e)
        {
            listener.Stop();
            thread_listener.Abort();
            bServerStart.Enabled = true;
            bServerStop.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread_listener != null && thread_listener.IsAlive)
            {
                listener.Stop();
                thread_listener.Abort();
            }
            FileStream fs = new FileStream("config.bin", FileMode.OpenOrCreate);
            fs.Seek(0, SeekOrigin.Begin);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, config);
            fs.Close();
        }
    }    
    public class ClientHandler
    {
        // Data
        private TcpClient client;
        private Form1 form;
        private static string _filePath = string.Format("{0}\\{1}", Environment.CurrentDirectory, "EventsFiles");


        public ClientHandler(TcpClient arg, Form1 f)
        {
            client = arg;
            form = f;
        }
        public void RunClient()
        {
            try
            {
                using (NetworkStream writerStream = client.GetStream())
                {
                    BinaryFormatter outFormatter = new BinaryFormatter();
                    MSG message;
                    message = (MSG)outFormatter.Deserialize(writerStream);
                    switch (message.stat)
                    {
                        case STATUS.LOGIN:
                            string login = (string)outFormatter.Deserialize(writerStream);
                            string password = (string)outFormatter.Deserialize(writerStream);
                            Account ac = DbUtilities.Login(login, password);
                            bool fll = true;
                            if (ac == null)
                            {
                                fll = false;
                                outFormatter.Serialize(writerStream, fll);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, fll);
                                outFormatter.Serialize(writerStream, ac);
                            }
                            break;
                        case STATUS.GET_GROUPS:
                            Dictionary<string, int> dic = DbUtilities.GetGroups();
                            bool gg = true;
                            if (dic == null)
                            {
                                gg = false;
                                outFormatter.Serialize(writerStream, gg);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, gg);
                                outFormatter.Serialize(writerStream, dic);
                            }
                            break;
                        case STATUS.GET_SPECIALITIES:
                            var specialities = DbUtilities.GetSpecialities();
                            if (specialities == null)
                            {
                                outFormatter.Serialize(writerStream, false);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, true);
                                outFormatter.Serialize(writerStream, specialities);
                            }
                            break;
                        case STATUS.ADD_SPECIALITY:
                            DbUtilities.AddSpeciality((Speciality)outFormatter.Deserialize(writerStream));
                            break;
                        case STATUS.DELETE_SPECIALITY:
                            outFormatter.Serialize(writerStream, DbUtilities.DeleteSpecility((int)outFormatter.Deserialize(writerStream)));
                            break;
                        case STATUS.EDIT_SPECIALITY:
                            DbUtilities.UpdateSpeciality((Speciality)outFormatter.Deserialize(writerStream));
                            break;
                        case STATUS.ADD_STUDENT:
                            Student st = (Student)outFormatter.Deserialize(writerStream);
                            bool fl = true;
                            try
                            {
                                DbUtilities.AddAccount(st);
                            }
                            catch (Exception)
                            {
                                fl = false;
                            }
                            outFormatter.Serialize(writerStream, fl);
                            break;
                        case STATUS.GET_PROJECT_BY_STUDENT:
                            int id = (int)outFormatter.Deserialize(writerStream);
                            List<Project> ProjectCoollection = DbUtilities.GetProjects(id);
                            bool flpc = true;
                            if (ProjectCoollection == null)
                            {
                                flpc = false;
                                outFormatter.Serialize(writerStream, flpc);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, flpc);
                                outFormatter.Serialize(writerStream, ProjectCoollection);
                            }
                            break;
                        case STATUS.GET_EVENTS_BY_PROJECT:
                            int prid = (int)outFormatter.Deserialize(writerStream);
                            List<Event> evCollection = DbUtilities.GetEvents(prid);
                            bool flgebp = true;
                            if (evCollection == null)
                            {
                                flgebp = false;
                                outFormatter.Serialize(writerStream, flgebp);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, flgebp);
                                outFormatter.Serialize(writerStream, evCollection);
                            }
                            break;
                        case STATUS.ADD_INSTRUCTOR:
                            Instructor instr = (Instructor)outFormatter.Deserialize(writerStream);
                            bool instr_add_fl = true;
                            try
                            {
                                DbUtilities.AddAccount(instr);
                            }
                            catch (Exception)
                            {
                                fl = false;
                            }
                            outFormatter.Serialize(writerStream, instr_add_fl);
                            break;
                        case STATUS.GET_STUDENTS_NAME_BY_GROUP:
                            var nameGSNBG = (string)outFormatter.Deserialize(writerStream);
                            var dicGSNBG = DbUtilities.GetStudentsByGroup(nameGSNBG);
                            bool flGSNBG = true;
                            if (dicGSNBG == null)
                            {
                                flGSNBG = false;
                                outFormatter.Serialize(writerStream, flGSNBG);
                            }
                            else
                            {
                                List<StringToInt> dicGSNBG2 = new List<StringToInt>();
                                
                                foreach (var i in dicGSNBG)
                                {
                                    dicGSNBG2.Add(new StringToInt(i.Fullname, i.StudentId));
                                }
                                outFormatter.Serialize(writerStream, flGSNBG);
                                outFormatter.Serialize(writerStream, dicGSNBG2);
                            }
                            break;
                        case STATUS.CREATE_LABS:
                            LabWorks lwCL = (LabWorks)outFormatter.Deserialize(writerStream);
                            List<int> stIdCollectionCL = (List<int>)outFormatter.Deserialize(writerStream);
                            DbUtilities.AddParentProject(lwCL);
                            foreach (int i in stIdCollectionCL)
                            {
                                LabWorks t = new LabWorks(lwCL.InstructorId, lwCL.ID, lwCL.Theme, lwCL.Description)
                                {
                                    Subject = lwCL.Subject
                                };
                                DbUtilities.AddProject(t);
                                DbUtilities.AddStudentToProject(i, t.ID);
                            }
                            outFormatter.Serialize(writerStream, true);
                            break;
                        case STATUS.CREATE_RGR:
                            RGR rgrCL = (RGR)outFormatter.Deserialize(writerStream);
                            List<int> stIdCollectionCR = (List<int>)outFormatter.Deserialize(writerStream);
                            DbUtilities.AddParentProject(rgrCL);
                            foreach (int i in stIdCollectionCR)
                            {
                                RGR t = new RGR(rgrCL.InstructorId, rgrCL.ID, rgrCL.Theme, rgrCL.Description)
                                {
                                    Subject = rgrCL.Subject
                                };
                                DbUtilities.AddProject(t);
                                DbUtilities.AddStudentToProject(i, t.ID);
                            }
                            outFormatter.Serialize(writerStream, true);
                            break;
                        case STATUS.GET_SUBJECTS_BY_INSTRUCTOR_ID:
                            var dicGSBII = DbUtilities.GetSubjects(); 
                            bool flGSBII = true;
                            if (dicGSBII == null)
                            {
                                flGSBII = false;
                                outFormatter.Serialize(writerStream, flGSBII);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, flGSBII);
                                outFormatter.Serialize(writerStream, dicGSBII);
                            }
                            break;
                        case STATUS.GET_LABS_BY_INSTRUCTOR:
                            int instrID = (int)outFormatter.Deserialize(writerStream);
                            List<Project> prByInstrCollection = DbUtilities.GetProjectsByInstructor(instrID);
                            List<Project> outputLabs = new List<Project>();
                            foreach (var pr in prByInstrCollection)
                                if (pr.Type == EProjectType.LabWork)
                                    outputLabs.Add(pr);
                            outFormatter.Serialize(writerStream, outputLabs);
                            break;
                        case STATUS.ADD_EVENT:
                            Event ev = (Event)outFormatter.Deserialize(writerStream);
                            bool flAE = DbUtilities.AddEvent(ev);
                            outFormatter.Serialize(writerStream, flAE);
                            break;
                        case STATUS.UPDATE_EVENT:
                            Event evUpd = (Event)outFormatter.Deserialize(writerStream);
                            DbUtilities.UpdateEvent(evUpd);
                            bool flUE = true;
                            outFormatter.Serialize(writerStream, true);
                            break; 
                        case STATUS.GET_PROJECT_BY_ID:
                            int idGPBI = (int) outFormatter.Deserialize(writerStream);
                            outFormatter.Serialize(writerStream, DbUtilities.GetProjectById(idGPBI));
                            break;
                        case STATUS.GET_STUDENTS_ID_BY_PARENT:
                            int prID = (int) outFormatter.Deserialize(writerStream);
                            var prCollection = DbUtilities.GetProjectsByParentId(prID);
                            List<int> stInProj = new List<int>();
                            foreach (var pr in prCollection)
                            {
                                foreach (var stGSIBP in DbUtilities.GetStudentsByProjectId(pr.ID))
                                    stInProj.Add(stGSIBP.StudentId);
                            }
                            outFormatter.Serialize(writerStream, stInProj);
                            break;
                        case STATUS.EDIT_LABS:
                            LabWorks lwEL = (LabWorks)outFormatter.Deserialize(writerStream);
                            int parId = lwEL.ID;
                            var studentCollection = (List<int>)outFormatter.Deserialize(writerStream);
                            foreach (var student in studentCollection)
                            {
                                bool exist = false;
                                var projectCollection = DbUtilities.GetProjectsByParentId(lwEL.ID, false);
                                foreach (var project in projectCollection)
                                {
                                    bool deleteProject = true;
                                    var studInProject = DbUtilities.GetStudentsByProjectId(project.ID);
                                    foreach (var stud in studInProject)
                                    {
                                        if (studentCollection.Exists(arg => arg == stud.StudentId))
                                        {
                                            deleteProject = false;
                                        }
                                        if (student == stud.StudentId)
                                        {
                                            exist = true;
                                            break;
                                        }
                                        if (deleteProject)
                                        {
                                            DbUtilities.DeleteProject(project.ID);
                                        }
                                    }
                                }
                                if (!exist)
                                {
                                    LabWorks t = lwEL;
                                    t.ParentProjectId = parId;
                                    DbUtilities.AddProject(t);
                                    DbUtilities.AddStudentToProject(student, t.ID);
                                }
                            }
                            outFormatter.Serialize(writerStream, true);
                            break;
                        case STATUS.EDIT_RGR:
                            RGR rgrER = (RGR)outFormatter.Deserialize(writerStream);
                            DbUtilities.UpdateProject(rgrER);
                            int parIder = rgrER.ID;
                            var studentCollectionER = (List<int>)outFormatter.Deserialize(writerStream);
                            foreach (var student in studentCollectionER)
                            {
                                bool exist = false;
                                var projectCollection = DbUtilities.GetProjectsByParentId(rgrER.ID, false);
                                foreach (var project in projectCollection)
                                {
                                    bool deleteProject = true;
                                    var studInProject = DbUtilities.GetStudentsByProjectId(project.ID);
                                    foreach (var stud in studInProject)
                                    {
                                        if (studentCollectionER.Exists(arg => arg == stud.StudentId))
                                        {
                                            deleteProject = false;
                                        }
                                        if (student == stud.StudentId)
                                        {
                                            exist = true;
                                            break;
                                        }
                                        if (deleteProject)
                                        {
                                            DbUtilities.DeleteProject(project.ID);
                                        }
                                    }
                                }
                                if (!exist)
                                {
                                    RGR t = rgrER;
                                    t.ParentProjectId = parIder;
                                    DbUtilities.AddProject(t);
                                    DbUtilities.AddStudentToProject(student, t.ID);
                                }
                            }
                            outFormatter.Serialize(writerStream, true);
                            break;
                        case STATUS.ADD_GROUP:
                            string name = (string) outFormatter.Deserialize(writerStream);
                            var facultyAddGroup = (Faculties)outFormatter.Deserialize(writerStream);
                            bool flAddGroup = true;
                            try
                            {
                                DbUtilities.AddGroup(name, facultyAddGroup);
                            }
                            catch (Exception)
                            {
                                flAddGroup = false;
                            }
                            outFormatter.Serialize(writerStream, flAddGroup);
                            break;
                        case STATUS.DELETE_EVENT:
                            DbUtilities.DeleteEvent((int)outFormatter.Deserialize(writerStream));
                            break;
                        case STATUS.EDIT_GROUP:
                            string oldGroupName = (string) outFormatter.Deserialize(writerStream);
                            string newGroupName = (string) outFormatter.Deserialize(writerStream);
                            bool flEditGroup = true; 
                            try
                            {
                                DbUtilities.UpdateGroup(newGroupName, oldGroupName);
                            }
                            catch (Exception ex)
                            {
                                flEditGroup = false;
                            }
                            outFormatter.Serialize(writerStream, flEditGroup);
                            break;
                        case STATUS.GET_GROUP_BY_FACULTY:
                            var fuck = (Faculties)outFormatter.Deserialize(writerStream);
                            var groupsByFuck = DbUtilities.GetGroupsByFaculty(fuck);
                            if (groupsByFuck == null)
                            {
                                outFormatter.Serialize(writerStream, false);
                            }
                            else
                            {
                                outFormatter.Serialize(writerStream, true);
                                outFormatter.Serialize(writerStream, groupsByFuck);
                            }
                            break;
                        case STATUS.DELETE_GROUP:
                            int idGroup = (int) outFormatter.Deserialize(writerStream);
                            bool flDeleteGroup = true;
                            try
                            {
                                DbUtilities.DeleteGroup(idGroup);
                            }
                            catch (Exception)
                            {
                                flDeleteGroup = false;
                            }
                            outFormatter.Serialize(writerStream, flDeleteGroup);
                            break;
                        case STATUS.GET_SUBJECTS:
                            bool flGetSubjects = true;
                            Dictionary<string, int> subjects = new Dictionary<string, int>();
                            try
                            {
                                subjects = DbUtilities.GetSubjects();
                            }
                            catch (Exception ex)
                            {
                                flGetSubjects = false;
                            }
                            outFormatter.Serialize(writerStream, flGetSubjects);
                            if(flGetSubjects)
                                outFormatter.Serialize(writerStream, subjects);
                            break;
                        case STATUS.ADD_SUBJECT:
                            bool flAddSubject = true;
                            string subjectName = (string) outFormatter.Deserialize(writerStream);
                            try
                            {
                                DbUtilities.AddSubject(subjectName);
                            }
                            catch (Exception ex)
                            {
                                flAddSubject = false;
                            }
                            outFormatter.Serialize(writerStream, flAddSubject);
                            break;
                        case STATUS.EDIT_SUBJECT:
                            bool flEditSubject = true;
                            string editSubjectName = (string) outFormatter.Deserialize(writerStream);
                            int subjectId = (int)outFormatter.Deserialize(writerStream);
                            try
                            {
                                DbUtilities.UpdateSubject(subjectId, editSubjectName);
                            }
                            catch (Exception ex)
                            {
                                flEditSubject = false;
                            }
                            outFormatter.Serialize(writerStream, flEditSubject);
                            break;
                        case STATUS.DELETE_SUBJECT:
                            bool flDeleteSubject = true;
                            int deleteSubjectId = (int) outFormatter.Deserialize(writerStream);
                            try
                            {
                                DbUtilities.DeleteSubject(deleteSubjectId);
                            }
                            catch (Exception)
                            {
                                flDeleteSubject = false;
                            }
                            outFormatter.Serialize(writerStream, flDeleteSubject);
                            break;
                        case STATUS.GET_STUDENTS:
                            bool flGetStudents = true;
                            int instrId = (int) outFormatter.Deserialize(writerStream);
                            List<Student> students = new List<Student>();
                            try
                            {
                                students = DbUtilities.GetStudentsByInstructorId(instrId);
                            }
                            catch (Exception)
                            {
                                flGetStudents = false;
                            }
                            outFormatter.Serialize(writerStream, flGetStudents);
                            if (flGetStudents)
                            {
                                outFormatter.Serialize(writerStream, students);
                            }
                            break;
                        case STATUS.ADD_FILE:
                            int fileTypeId = (int)outFormatter.Deserialize(writerStream);
                            EventFileType fileType;
                            // Преподаватель
                            if (fileTypeId == 0)
                            {
                                fileType = EventFileType.Input;
                            }
                            else
                            {
                                fileType = EventFileType.Output;
                            }
                            int eventId = (int)outFormatter.Deserialize(writerStream);
                            int countFiles = (int)outFormatter.Deserialize(writerStream);
                            for (int i = 0; i < countFiles; i++)
                            {
                                string addInstructorFileName = (string)outFormatter.Deserialize(writerStream);
                                string addInstructorFileDirectory = string.Format("{0}\\{1}", _filePath, eventId.ToString());
                                if (!Directory.Exists(addInstructorFileDirectory))
                                {
                                    Directory.CreateDirectory(addInstructorFileDirectory);
                                }
                                string addInstructorLocalFileName = string.Format("{0}\\{1}", addInstructorFileDirectory, addInstructorFileName);
                                if (!File.Exists(addInstructorLocalFileName))
                                {
                                    DbUtilities.UploadFile(eventId, addInstructorFileName, addInstructorLocalFileName, fileType);
                                }
                                byte[] fileBytes = (byte[])outFormatter.Deserialize(writerStream);
                                File.WriteAllBytes(addInstructorLocalFileName, fileBytes);
                            }
                            break;
                        case STATUS.GET_FILES:
                            int eventIdGF = (int)outFormatter.Deserialize(writerStream);
                            bool giveStudentFiles = (bool)outFormatter.Deserialize(writerStream);
                            outFormatter.Serialize(writerStream, DbUtilities.GetEventFileDictionary(eventIdGF, EventFileType.Input));
                            if (giveStudentFiles)
                            {
                                outFormatter.Serialize(writerStream, DbUtilities.GetEventFileDictionary(eventIdGF, EventFileType.Output));    
                            }
                            break;
                        case STATUS.DELETE_FILE:
                            int eventDFId = (int)outFormatter.Deserialize(writerStream);
                            int countDelFiles = (int)outFormatter.Deserialize(writerStream);
                            for (int i = 0; i < countDelFiles; i++)
                            {
                                string delFileName = (string)outFormatter.Deserialize(writerStream);
                                File.Delete(delFileName);
                                DbUtilities.DeleteFile(delFileName, eventDFId);
                            }
                            outFormatter.Serialize(writerStream, true);
                            break;
                        case STATUS.GET_ACCOUNT_BY_ID:
                            int accountId = (int)outFormatter.Deserialize(writerStream);
                            Account acc = DbUtilities.GetAccountbyId(accountId);
                            outFormatter.Serialize(writerStream, acc);
                            break;
                        case STATUS.GET_RGR_BY_INSTRUCTOR:
                            int instrIDGRBI = (int)outFormatter.Deserialize(writerStream);
                            List<Project> prByInstrCollection1 = DbUtilities.GetProjectsByInstructor(instrIDGRBI);
                            List<Project> outputRGR = new List<Project>();
                            foreach (var pr in prByInstrCollection1)
                                if (pr.Type == EProjectType.Rgr)
                                    outputRGR.Add(pr);
                            outFormatter.Serialize(writerStream, outputRGR);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                
            }
            /*StreamReader readerStream = new StreamReader(client.GetStream());
            NetworkStream writerStream = client.GetStream();
            string returnData = readerStream.ReadLine();
            returnData += "\r\n";
                byte[] dataWrite = Encoding.ASCII.GetBytes(ret.rnData);
                writerStream.Write(dataWrite, 0, dataWrite.Length);
           
            client.Close();*/
        }
    }
}
