using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RoomType
    {
        public RoomType(string name, int cantSmallBed, int cantMediumBed, int cantLargeBed, bool share)
        {
            Name = name;
            CantSmallBed = cantSmallBed;
            CantMediumBed = cantMediumBed;
            CantLargeBed = cantLargeBed;
            Share = share;
            Rooms = new HashSet<Room>();
        }

        public string Name { get; set; }
        public int CantSmallBed { get; set; }
        public int CantMediumBed { get; set; }
        public int CantLargeBed { get; set; }
        public bool Share { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
