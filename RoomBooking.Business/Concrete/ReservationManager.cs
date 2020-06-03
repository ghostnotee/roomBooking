using RoomBooking.Business.Absract;
using RoomBooking.DataAccess.Absract;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private IReservation _reservationDal;
        public ReservationManager(IReservation reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation reservation)
        {
            _reservationDal.Add(reservation);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public List<Reservation> GetReservationsByRoomId(int roomId)
        {
            return _reservationDal.GetAll(r => r.RoomId == roomId);
        }

        public List<Reservation> GetReservationsByDateRange(DateTime start, DateTime end)
        {
            DateTime afterEdit = start.AddDays(1);
            return _reservationDal.GetAll(r => r.DateIn <= start && r.DateOut>= afterEdit);
        }

        public List<Reservation> GetByGuestId(int guestId)
        {
            return _reservationDal.GetAll(r=>r.GuestId==guestId);
        }

        public List<Reservation> GetReservationsIfCheckedIn(int id)
        {
            return _reservationDal.GetAll(r => r.Status == 2 && r.RoomId == id && r.CheckIn != null && r.CheckOut == null);
        }

        public List<Reservation> GetReservationsOfToday(int id)
        {
            return _reservationDal.GetAll(r => r.Status == 1 && r.RoomId == id && r.CheckIn == null && r.CheckOut == null );
        }

        public void Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }

        public Reservation Get(int id)
        {
            return _reservationDal.Get(g => g.Id == id);
        }
    }
}
