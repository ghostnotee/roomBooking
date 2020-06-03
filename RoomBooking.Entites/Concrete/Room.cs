using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Entites.Concrete
{
    public class Room:IEntity
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public byte Number { get; set; }        
        public string Name { get; set; }
        public int Status { get; set; }
        public int? IsActive { get; set; }
    }
}
