using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //TODO: Gotta add and change properties
    public class Room
    {
        public Room(string number, Guid roomTypeId, RoomStatus status)
        {
            Number = number;
            RoomTypeId = roomTypeId;
            Status = status;
        }

        public string Number { get; set; }
        public Guid RoomTypeId { get; set; }
        public virtual RoomType? RoomType { get; set; }
        public float Price { get; set; }
        public RoomStatus Status { get; set; }
    }
}
