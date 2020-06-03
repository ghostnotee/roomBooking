using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Business.Absract
{
    public interface IRoomService
    {
        List<Room> GetAll();
        void Update(Room room);
        Room Get(int roomId);
        void Add(Room room);
        void Delete(Room room);
    }
}
