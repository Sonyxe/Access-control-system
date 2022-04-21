using Access_control_system.Models;
using System;
using System.Collections.Generic;

namespace AccessControl_System.DataAccess
{
    public class DoorRepo
    {
        private List<Door> doorList { get; }
        private List<int> accessCodes1 { get; }
        private List<int> accessCodes2 { get; }


        public DoorRepo()
        {
            accessCodes1 = new List<int> { 1, 2, 3, 4 };
            accessCodes2 = new List<int> { 1, 2, 3 };

            Door door1 = new Door(1, accessCodes1);
            Door door2 = new Door(2, accessCodes2);


            doorList = new List<Door> { door1, door2 };
        }
        public List<Door> Retrieve()
        {
            return doorList;
        }
        public Door RetrieveDoor(int doorId)
        {
            return doorList[doorId];
        }
        public List<int> RetrieveDoorAccessCodes(int doorId)
        {
            try
            {


                return doorList[doorId].AccessCodesId;

            }
            catch(Exception e)
            {
                Console.WriteLine($"the number entered must be, +{e}");
                return null;
            }
        }
    }
}





