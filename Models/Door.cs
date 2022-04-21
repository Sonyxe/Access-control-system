using System.Collections.Generic;


namespace Access_control_system.Models
{
    public class Door
    {
        public int Id { get; }
        public List<int> AccessCodesId { get; set; }

        public Door(int id, List<int> accessCodesId)
        {
            Id = id;
            AccessCodesId = accessCodesId;
        }

        
    }
}