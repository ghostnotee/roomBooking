using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Business.Absract
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        void Add(Reservation reservation);
        List<Reservation> GetReservationsByRoomId(int roomId);
        List<Reservation> GetReservationsByDateRange(DateTime start,DateTime end);
        List<Reservation> GetByGuestId(int guestId);
        List<Reservation> GetReservationsIfCheckedIn(int id);
        List<Reservation> GetReservationsOfToday(int id);
        void Update(Reservation reservation);
        Reservation Get(int id);
    }
}
