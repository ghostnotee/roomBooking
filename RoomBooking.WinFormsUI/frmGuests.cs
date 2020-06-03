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
    public partial class frmGuests : Form
    {
        public frmGuests()
        {
            InitializeComponent();
            _guestService = new GuestManager(new EfGuestDal());
        }

        private IGuestService _guestService;

        private void btnGuestAdd_Click(object sender, EventArgs e)
        {
            frmGuest frmGuest = new frmGuest();
            frmGuest.ShowDialog();
            LoadGuests();
        }

        private void frmGuests_Load(object sender, EventArgs e)
        {
            LoadGuests();
        }

        public void LoadGuests()
        {
            dgvGuests.DataSource = _guestService.GetAll();
        }

        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            Guest guestToEdit=_guestService.Get(Int16.Parse(dgvGuests.SelectedRows[0].Cells[0].Value.ToString()));
            frmGuest frmGuest = new frmGuest(guestToEdit);
            frmGuest.ShowDialog();
            LoadGuests();
        }

        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            _guestService.Delete(new Guest { Id = Convert.ToInt32(dgvGuests.CurrentRow.Cells[0].Value) });
            MessageBox.Show("Konuk Silindi");
            LoadGuests();
        }

        private void btnGuestReservations_Click(object sender, EventArgs e)
        {
            int guestId = Convert.ToInt32(dgvGuests.SelectedRows[0].Cells[0].Value);
            frmReservationsByGuest reservationsByGuest = new frmReservationsByGuest(guestId);
            reservationsByGuest.ShowDialog();
        }
    }
}
