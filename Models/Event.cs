using System;

namespace Access_control_system.Models
{
    public class Event
    {
     public Person Person { get; set; }
     public DateTime EntryTime { get; set; }

        public Event(Person person, DateTime entryTime) 
        {
            Person = person;
            EntryTime = entryTime;
        }
    }
}
