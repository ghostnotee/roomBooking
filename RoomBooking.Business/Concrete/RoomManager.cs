using RoomBooking.Business.Absract;
using RoomBooking.DataAccess.Absract;
using RoomBooking.DataAccess.Concrete.EntityFramework;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private IRoomDal _roomDal;
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Add(Room room)
        {
            _roomDal.Add(room);
        }

        public void Delete(Room room)
        {
            _roomDal.Delete(room);
        }

        public Room Get(int roomId)
        {
            return _roomDal.Get(r => r.Id == roomId);
        }

        public List<Room> GetAll()
        {
            return _roomDal.GetAll();
        }

        public void Update(Room room)
        {
            _roomDal.Update(room);
        }
    }
}
