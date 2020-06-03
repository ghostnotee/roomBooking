using RoomBooking.DataAccess.Absract;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Concrete.EntityFramework
{
    public class EfRoomTypeDal : EfEntityRepositoryBase<RoomType, RoomBookingContext>,IRoomTypeDal
    {
    }
}
