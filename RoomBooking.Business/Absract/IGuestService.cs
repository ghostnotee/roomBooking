using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Business.Absract
{
   public interface IGuestService
    {
        List<Guest> GetAll();
        void Add(Guest guest);
        Guest Get(int id);
        Guest GetByTcNo(string text);
        void Update(Guest guest);
        void Delete(Guest guest);
    }
}
