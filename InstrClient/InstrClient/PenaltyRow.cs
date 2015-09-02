using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrClient
{
    class PenaltyRow
    {
        public string Description { get; set; }
        public string Mode { get; set; }
        public string Value { get; set; }
        public PenaltyRow() { }
        public PenaltyRow(string description, int mode)
        {
            Description = description;
            Mode = mode.ToString();
            Value = "-";
        }
        public PenaltyRow(string description, double value)
        {
            Description = description;
            Mode = "-";
            Value = value.ToString();
        }
        
    }
}
