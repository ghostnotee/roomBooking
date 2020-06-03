using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Entites.Concrete
{
   public class RoomType:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MaxCapacity { get; set; }
        public int? IsActive { get; set; }
    }
}
