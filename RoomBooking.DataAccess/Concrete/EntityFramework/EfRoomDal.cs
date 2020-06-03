using RoomBooking.DataAccess.Absract;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Concrete.EntityFramework
{
    public class EfRoomDal:EfEntityRepositoryBase<Room,RoomBookingContext>,IRoomDal
    {           
    }
}
 