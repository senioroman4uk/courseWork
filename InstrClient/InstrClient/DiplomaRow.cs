using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrClient
{
    class DiplomaRow
    {
        public string RecordBookNumber { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public string Application { get; set; }
        public string PZ { get; set; }
        public string Response { get; set; }
        public string Reviewer { get; set; }
        public string Review { get; set; }
        public string PracticeReport { get; set; }
        public string PracticeECTS { get; set; }
        public string PracticePoints { get; set; }
        public string PreDefense { get; set; }
        public string DefenseDate { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }
        public string Date3 { get; set; }
        public string Date4 { get; set; }
        public string Date5 { get; set; }
        public DiplomaRow() { }
        public DiplomaRow(string recordBookNumber, string fullName, string group,  string preDefense, string defenseDate, string date1, string date2, string date3, 
            string date4 = "", string date5 = "", string practiceReport = "-", string practiceECTS = "-", string practicePoints = "0", string application = "",
            string pz = "-", string response = "-", string reviewer = "-", string review = "-")
        {
            RecordBookNumber = recordBookNumber;
            FullName = fullName;
            Group = group;
            PracticeReport = practiceReport;
            PracticeECTS = practiceECTS;
            PracticePoints = practicePoints;
            Application = application;
            PZ = pz;
            Response = response;
            Reviewer = reviewer;
            Review = review;
            PreDefense = preDefense;
            DefenseDate = defenseDate;
            Date1 = date1;
            Date2 = date2;
            Date3 = date3;
            Date4 = date4;
            Date5 = date5;
        }
    }
}
