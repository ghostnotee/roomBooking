using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Entites
{
    public class ReservedRoom:IEntity
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int NumberOfRooms { get; set; }
        public int Status { get; set; }
    }
}
