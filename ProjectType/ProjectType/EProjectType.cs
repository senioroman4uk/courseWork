using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectType
{
    [Serializable]
    public enum EventStatus { NotPassed, Passed, Blocked }
    [Serializable]
    public enum ProjectStatus { NotPassed, Passed }
    [Serializable]
    public enum EProjectType
    {
        Undefined = 0, Rgr = 1, LabWork = 2, DiplomaProject = 3, CourseWork = 4
    }
    [Serializable]
    public class Event
    {
        public int ID { get; set; }

        /// VRomanchuk 23.05.2015 2.51:
        /// <summary>
        ///     Додав оскільки не буде зрозуміло до якого проекту відноситься Event
        /// </summary>
        public int ProjectId { get; set; }
        public int SerialNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime AcceptDate { get; set; }
        public EventStatus EStatus { get; set; }
        public double Mark { get; set; }
        public double Penalty { get; set; }
        public List<Penalty> PenaltyCollection { get; set; }
        public double RealMark
        {
            get { return Mark * Penalty; }
        }

        public Dictionary<string, string> InputFiles { get; set; }
        public Dictionary<string, string> OutputFiles { get; set; }

        public Event(int projectId, int snumber, string title, DateTime dLine, string description = "", DateTime dateOfCreation = new DateTime())
        {
            ProjectId = projectId;
            SerialNumber = snumber;
            Title = title;
            DeadLine = dLine;
            Description = description;
            EStatus = EventStatus.NotPassed;
            Mark = 0;
            Penalty = 1;
            DateOfCreation = dateOfCreation;
        }
    }
    [Serializable]
    public abstract class Project
    {
        protected EProjectType type;
        public int InstructorId { get; set; }
        public int ParentProjectId { get; set; }

        public EProjectType Type { get { return type; } }
        public string Theme { get; set; }
        public ProjectStatus PStatus { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public List<Event> Events { get; set; }

        public string Subject { get; set; }

        public int EventCount
        {
            get
            {
                if (Events == null)
                    return 0;
                else
                    return Events.Count;
            }
        }
        protected Project(int instructorId, int parentProjectId, EProjectType type, string theme, string descr = "")
        {
            InstructorId = instructorId;
            ParentProjectId = parentProjectId;
            Theme = theme;
            Description = descr;
            PStatus = ProjectStatus.NotPassed;
            this.type = type;
        }
    }
    [Serializable]
    public class LabWorks : Project
    {
        public LabWorks(int instructorId, int parentProjectId, string theme, string descr = "")
            : base(instructorId, parentProjectId, EProjectType.LabWork, theme, descr) { }
    }
    [Serializable]
    public class RGR : Project
    {
        public RGR(int instructorId, int parentProjectId, string theme, string descr = "")
            : base(instructorId, parentProjectId, EProjectType.Rgr, theme, descr) { }
    }
    [Serializable]
    public class DiplomaProject : Project
    {
        public List<string> DefenceDate { get; set; }
        public int DiplomaId { get; set; }

        public DiplomaProject(int instructorId, int parentProjectId, string theme, string descr = "")
            : base(instructorId, parentProjectId, EProjectType.DiplomaProject, theme, descr) { }
        //TODO: Add check for empty
        //Це повинно бути ФІО Наприклад Якименко Стефан Вікторович
        public string InstroctorName { get; set; }

        public string NormokontrolerName { get; set; }

        public string Classification { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfPictures { get; set; }
        public int NumberOfTables { get; set; }
        public int NumberOfFormuls { get; set; }
        public int NumberOfLiterature { get; set; }
        public int NumberOfPosters { get; set; }
    }

    [Serializable]
    public class Penalty
    {
        public int PenaltyID { get; set; }
        public int EventID { get; set; }
        public string Description { get; set;}
        public double Value { get; set; }
        public int Mode { get; set; }

        public Penalty(double value, string description, int mode, int eventID = 0, int penaltyID = 0)
        {
            Value = value;
            Description = description;
            Mode = mode;
            EventID = eventID;
            PenaltyID = penaltyID;
        }
    }
}