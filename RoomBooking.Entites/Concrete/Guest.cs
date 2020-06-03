using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Entites.Concrete
{
   public class Guest:IEntity
    {
        public int Id { get; set; }
        public string TCIdNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
