using RoomBooking.DataAccess.Absract;
using RoomBooking.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.DataAccess.Concrete.EntityFramework
{
    public class EfReservedRoomDal: EfEntityRepositoryBase<ReservedRoom, RoomBookingContext>,IReservedRoomDal
    {
    }
}
