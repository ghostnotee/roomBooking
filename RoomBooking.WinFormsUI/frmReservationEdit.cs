using RoomBooking.Business.Absract;
using RoomBooking.Business.Concrete;
using RoomBooking.DataAccess.Concrete.EntityFramework;
using RoomBooking.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBooking.WinFormsUI
{
    public partial class frmReservationEdit : Form
    {
        public frmReservationEdit()
        {
            InitializeComponent();
            _reservationService = new ReservationManager(new EfReservationDal());
            _guestService = new GuestManager(new EfGuestDal());
            _roomService = new RoomManager(new EfRoomDal());
        }

        private IReservationService _reservationService;
        private IGuestService _guestService;
        private IRoomService _roomService;
        private int status = 0;

        private void btnReservationAdd_Click(object sender, EventArgs e)
        {
            status = DateTime.Compare(DateTime.Now, dteDateIn.DateTime.Date);
            Guest guest = GuestControl();

            try
            {
                if (guest == null)
                {
                    _guestService.Add(new Guest
                    {
                        FirstName = txbGuestName.Text,
                        LastName = txbGuestLastName.Text,
                        TCIdNo = txbTCIdNo.Text
                    });

                }
                GuestControl();

                _reservationService.Add(new Reservation
                {
                    GuestId = guest.Id,
                    RoomId = Convert.ToInt32(dgwEmptyRooms.SelectedRows[0].Cells[0].Value),
                    DateIn = dteDateIn.DateTime.Date,
                    DateOut = dteDateOut.DateTime.Date,
                    Status = status
                });
                MessageBox.Show("Kayıt Yapıldı");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız");
            }            
            this.Close();
        }

        private Guest GuestControl()
        {
            Guest guestFound = _guestService.GetByTcNo(txbTCIdNo.Text);
            if (guestFound != null) {
                txbGuestName.Text = guestFound.FirstName;
                txbGuestLastName.Text = guestFound.LastName;
            }
            return guestFound;
        }


        private void btnUsableRooms_Click(object sender, EventArgs e)
        {
            DateTime start = dteDateIn.DateTime.Date;
            DateTime end = dteDateOut.DateTime.Date;
            if (end <= start)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden ileri bir değer seçilmelidir.", "Hatalı tarih aralığı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Room> roomsAvailable = _roomService.GetAll();
                List<Reservation> reservations = _reservationService.GetReservationsByDateRange(start, end);

                //MessageBox.Show("Bu tarih aralığında " + reservations.Count + " rezervasyon mevcut!");

                foreach (Reservation reservation in reservations)

                    for (int r = 0; r < roomsAvailable.Count; r++)
                        if (roomsAvailable[r].Id == reservation.RoomId)
                            roomsAvailable.RemoveAt(r);

                dgwEmptyRooms.DataSource = roomsAvailable;
            }
        }

        private void txbTCIdNo_KeyPress(object sender, KeyPressEventArgs e)     // sayı girebilsin. diğer tc kontrolleri eklenebilir.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txbTCIdNo_Leave(object sender, EventArgs e)
        {
            GuestControl();
        }
    }
}
