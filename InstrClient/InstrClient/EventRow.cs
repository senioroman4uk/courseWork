using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrClient
{
    public class EventRow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Deadline { get; set; }

        public EventRow(string id, string name, string deadline)
        {
            ID = id;
            Name = name;
            Deadline = deadline;
        }

        public EventRow()
        {

        }
    }
}
