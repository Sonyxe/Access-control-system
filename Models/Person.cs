using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_control_system.Models
{
    public class Person
    {
        public int Id { get;}
        public string Name { get;}
        public DateTime EntryTime { get; }

        public Person(int id, string name, DateTime entryTime) 
        {
            Id = id;
            Name = name;
            EntryTime = entryTime;
        }

        public object GeneratePersonList()
        {
            throw new NotImplementedException();
        }

        public Person()
        {
        }
    }
}
