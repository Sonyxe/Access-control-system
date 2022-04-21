using AccessControl_System.DataAccess;
using System;
using System.Collections.Generic;

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

        public Event()
        {
        }

        public bool Check(int personNm, int doorNm)
        {
            PersonRepo personRepo = new PersonRepo();
            DoorRepo doorRepo = new DoorRepo();
            List<int> doorAccessCodes = doorRepo.RetrieveDoorAccessCodes(doorNm);

            return doorAccessCodes.Contains(personNm);
        }
    }
}

