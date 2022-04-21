using Access_control_system.Models;
using System;
using System.Collections.Generic;

namespace AccessControl_System.DataAccess
{
    public class PersonRepo
    {
        public List<Person> persons { get; }
        public PersonRepo()
        {
            Person person1 = new Person(1, "Person1", DateTime.Now);
            Person person2 = new Person(2, "Person2", DateTime.Now);
            Person person3= new Person(3, "Person3", DateTime.Now);
            Person person4= new Person(4, "Person4", DateTime.Now);
            Person person5= new Person(5, "Person5", DateTime.Now);

            List<Person> persons = new List<Person> {person1,person2,person3,person4,person5 };
        }
        public List<Person> Retrieve()
        {
            return persons;
        }
        public Person RetrievePerson(int personId)
        {
            return persons[personId];
        }
    }
}







