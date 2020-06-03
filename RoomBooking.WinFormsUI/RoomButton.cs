using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomBooking.Entites.Concrete;
using RoomBooking.Business.Absract;
using RoomBooking.Business.Concrete;
using RoomBooking.DataAccess.Concrete.EntityFramework;

namespace RoomBooking.WinFormsUI
{
    public partial class RoomButton : UserControl
    {
        public Room room;
        public RoomButton(Room _room)
        {
            InitializeComponent();
            _reservationService = new ReservationManager(new EfReservationDal());
            _guestService = new GuestManager(new EfGuestDal());
            room = _room;
            this.Show();
        }

        private IReservationService _reservationService;
        private IGuestService _guestService;

        private void RoomClick()
        {
        
            frmShowReservations showReservations = new frmShowReservations(room);
            showReservations.ShowDialog();
        }

        public void UpdateInfo()
        {
            lblRoomName.Text = room.Name;

            // Odada kalan var mı?
            List<Reservation> rList = _reservationService.GetReservationsIfCheckedIn(room.Id);
            // Odada bugün için rezervasyon var mı?

            // Oda hizmete açık mı?
            if(room.IsActive == 1)
            {
                // Odada kalan biri varsa
                if(rList.Count > 0)
                {
                    Guest guest = _guestService.Get(rList[0].GuestId);
                    this.BackColor = Color.DarkGreen;
                    lblInfo.Text = guest.FirstName + " " + guest.LastName[0]+".";
                    lblRoomName.ForeColor = Color.FromArgb(255, 255, 255, 255);
                    lblInfo.ForeColor = Color.FromArgb(255, 255, 255, 255);
                }
                // Yoksa
                else
                {
                    rList = _reservationService.GetReservationsOfToday(room.Id);

                    // Bugün için giriş yapacak bir rezervasyon var mı?
                    if (rList.Count > 0)
                    {
                        this.BackColor = Color.CadetBlue;
                        lblInfo.Text = "";
                        lblRoomName.ForeColor = Color.FromArgb(255, 255, 255, 255);
                        lblInfo.ForeColor = Color.FromArgb(255, 255, 255, 255);

                    }
                    // Yoksa
                    else
                    {
                        this.BackColor = SystemColors.ControlDark;
                        lblInfo.Text = "";
                        lblRoomName.ForeColor = Color.FromArgb(255, 0, 0, 0);
                        lblInfo.ForeColor = Color.FromArgb(255, 0, 0, 0);

                    }

                }
            }
            else
            {
                this.BackColor = Color.Black;

                lblInfo.Text = "Kullanım Dışı";
            }
        }

        private void RoomButton_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void pnlContainer_Click(object sender, EventArgs e)
        {
            RoomClick();
            UpdateInfo();
        }
    }
}
