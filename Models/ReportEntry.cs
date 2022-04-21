using System.Collections.Generic;

namespace Access_control_system.Models
{
    public class ReportEntry
    {
        List<Event> EventList { get; set; }

        public ReportEntry(List<Event> eventList)
        {
            EventList = eventList;
        }
    }
}


