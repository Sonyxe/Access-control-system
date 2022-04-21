using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_control_system.Models
{
    public class ReportEntrysDuringPeriod
    {
        public List<Person> Person { get; set; }
        public List<int> EntryDuringPeriod { get; set; }

        public ReportEntrysDuringPeriod(List<Person> person, List<int> entryDuringPeriod)
        {
            Person = person;
            EntryDuringPeriod= entryDuringPeriod;
        }
    }
}