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
    public class GuestManager : IGuestService
    {
        private IGuestServis _guestDal;
        public GuestManager(IGuestServis guestDal)
        {
            _guestDal = guestDal;
        }

        public void Add(Guest guest)
        {
            _guestDal.Add(guest);
        }

        public void Delete(Guest guest)
        {
            _guestDal.Delete(guest);
        }

        public Guest Get(int id)
        {
            return _guestDal.Get(g=>g.Id==id);
        }

        public List<Guest> GetAll()
        {
            return _guestDal.GetAll();
        }

        public Guest GetByTcNo(string text)
        {
            return _guestDal.Get(g => g.TCIdNo == text);
        }

        public void Update(Guest guest)
        {
            _guestDal.Update(guest);
        }
    }
}
