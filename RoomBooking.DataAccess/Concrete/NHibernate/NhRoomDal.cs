using RoomBooking.DataAccess.Absract;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Concrete.NHibernate
{
    public class NhRoomDal : IRoomDal
    {
        public void Add(Room room)
        {
            throw new NotImplementedException();
        }

        public void Delete(Room room)
        {
            throw new NotImplementedException();
        }       

        public Room Get(Expression<Func<Room, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> filter = null)
        {
            List<Room> rooms = new List<Room>
            {
                new Room {Id=1,Number=1,Name="101",RoomTypeId=1,Status=1}
            };
            return rooms;
        }

        public void Update(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
