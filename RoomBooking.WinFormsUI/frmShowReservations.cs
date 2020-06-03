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
    public partial class frmShowReservations : Form
    {
        

        public frmShowReservations(Room room)
        {            
            InitializeComponent();
            _roomId = room.Id;
            _reservationService = new ReservationManager(new EfReservationDal());
            _guestService = new GuestManager(new EfGuestDal());

        }

        private int _roomId;
        private IReservationService _reservationService;
        private IGuestService _guestService;
        private Guest guest = null;
        private Reservation reservation = null;

        private void frmShowReservations_Load(object sender, EventArgs e)
        {
            this.Text = _roomId.ToString();

            UpdateInfo();


        }

        public void UpdateInfo()
        {
            List<Reservation> rList = _reservationService.GetReservationsByRoomId(_roomId);



            foreach (Reservation r in rList)
                if (r.CheckIn != null && r.CheckOut == null && r.Status == 2)
                {
                    guest = _guestService.Get(r.GuestId);
                    reservation = r;
                }


            if (reservation == null)
            {
                foreach (Reservation r in rList)
                    if (r.Status == 1 && r.RoomId == _roomId && r.CheckIn == null && r.CheckOut == null)
                    {
                        guest = _guestService.Get(r.GuestId);
                        reservation = r;
                    }
            }

            if (reservation == null)
            {
                btnCheckInOut.Enabled = false;
                btnCheckInOut.Visible = false;
            }
            else
            {
                lblFirstName.Text = guest.FirstName;
                lblLastName.Text = guest.LastName;
                lblID.Text = guest.TCIdNo;

                if (reservation.Status == 2)
                {
                    btnCheckInOut.Text = "Check Out Yap";
                }
            }


            var robotDogs = (from d in _reservationService.GetAll()
                             join f in _guestService.GetAll()
                             on d.GuestId equals f.Id
                             where d.RoomId == _roomId
                             select new
                             {
                                 d.Id,
                                 f.FirstName,
                                 f.LastName,
                                 d.DateIn,
                                 d.DateOut,
                                 d.CheckIn,
                                 d.CheckOut,
                                 d.Status,
                             }
                             ).ToList();

            dgwShowSelectedReservations.DataSource = robotDogs;
            dgwShowSelectedReservations.Columns[0].Visible = false;
            dgwShowSelectedReservations.Columns[1].HeaderText = "Ad";
            dgwShowSelectedReservations.Columns[2].HeaderText = "Soyd";
            dgwShowSelectedReservations.Columns[3].HeaderText = "Rezervasyon Başlangıç";
            dgwShowSelectedReservations.Columns[4].HeaderText = "Rezervasyon Bitiş";
            dgwShowSelectedReservations.Columns[5].HeaderText = "Check In";
            dgwShowSelectedReservations.Columns[6].HeaderText = "Check Out";
            dgwShowSelectedReservations.Columns[7].HeaderText = "Durum";

            //    dgwShowSelectedReservations.Columns[0].Visible = false;
            //    dgwShowSelectedReservations.Columns[2].Visible = false;
            //    dgwShowSelectedReservations.Columns[6].Visible = false;
            //    dgwShowSelectedReservations.Columns[7].Visible = false;
            //    foreach(DataGridViewRow dgvr in dgwShowSelectedReservations.Rows)
            //    {
            //        Guest g = _guestService.Get(Convert.ToInt32(dgvr.Cells[1].Value));

            //        dgvr.Cells[1].ValueType;

            //    }
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
          
            if(reservation.Status == 1)
            {
                DialogResult dr = MessageBox.Show("Bilgileri yazılı konuğun odaya giriş işlemi gerçekleştirilecek.\n Devam etmek istiyor musunuz?", "Check In Doğrulama", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if(dr.ToString() == "Yes")
                {
                    reservation.Status = 2;
                    reservation.CheckIn = DateTime.Now;
                    _reservationService.Update(reservation);
                    MessageBox.Show("Check In başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if(reservation.Status == 2)
            {
                DialogResult dr = MessageBox.Show("Konuğun odadan çıkış işlemi gerçekleştirilecek.\n Devam etmek istiyor musunuz?", "Check In Doğrulama", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);
                if (dr.ToString() == "Yes")
                {
                    reservation.Status = 3;
                    reservation.CheckOut = DateTime.Now;
                    _reservationService.Update(reservation);
                    MessageBox.Show("Check Out başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgwShowSelectedReservations.SelectedRows.Count > 0) {
                DialogResult dr = MessageBox.Show("Rezervasyon iptal edilecek.\n Devam etmek istiyor musunuz?", "Rezervasyon İptali", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
                if (dr.ToString() == "Yes")
                {
                    Reservation r = _reservationService.Get(Int16.Parse(dgwShowSelectedReservations.SelectedRows[0].Cells[0].Value.ToString()));
                    r.Status = -1;
                    _reservationService.Update(r);
                    MessageBox.Show("Rezervasyon iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateInfo();
                }
            
         
            }
        }
    }
}
