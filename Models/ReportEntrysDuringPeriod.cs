using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_control_system.Models
{
    public class ReportEntrysDuringPeriod
    {
        public Person Person { get; set; }
        public List<int> EntrysTimes { get; set; }

        public ReportEntrysDuringPeriod(Person person, List<int> entrysTimes) 
        {
            Person = person;
            EntrysTimes = entrysTimes;  
        }
    }
}
