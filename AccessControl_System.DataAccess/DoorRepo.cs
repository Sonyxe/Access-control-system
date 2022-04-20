using Access_control_system.Models;
using System.Collections.Generic;

namespace AccessControl_System.DataAccess
{
    public class DoorRepo
    {
        private List<int> accessCodesId;
        
        public DoorRepo()
        {
            accessCodesId = new List<int> { 1, 2, 3, 4, 5};
          
            Door door = new Door(1, accessCodesId);

        }
       
        public List<int>RetrieveAccessCodeId(int door) 
        {
            return accessCodesId;
        }
       

    }
}

    

