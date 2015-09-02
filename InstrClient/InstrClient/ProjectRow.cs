using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrClient
{
    public class ProjectRow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public ProjectRow() { }

        public ProjectRow(string id, string name, string descr, string deadline)
        {
            ID = id;
            Name = name;
            Description = descr;
            Deadline = deadline;
        }
    }
}
