using AccessControl_System.DataAccess;
using System;
using System.Collections.Generic;

namespace Access_control_system.Models
{
    public class Event
    {
        public Person Person { get; set; }
        public DateTime DateTime { get; set; }

        public Event(Person person, DateTime dateTime)
        {
            Person = person;
            DateTime = dateTime;
        }

        public Event()
        {
        }

        public bool Check(int personNumber, int doorNumber)
        {
            PersonRepo personRepo = new PersonRepo();
            DoorRepo doorRepo = new DoorRepo();
            List<int> doorAccessCodes = doorRepo.RetrieveDoorAccessCodes(doorNumber);

            return doorAccessCodes.Contains(personNumber);

        }
    }
}
        
 


