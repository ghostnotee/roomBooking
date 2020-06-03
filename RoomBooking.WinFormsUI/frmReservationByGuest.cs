using RoomBooking.Business.Absract;
using RoomBooking.Business.Concrete;
using RoomBooking.DataAccess.Absract;
using RoomBooking.DataAccess.Concrete.EntityFramework;
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
    public partial class frmReservationsByGuest : Form
    {
        public frmReservationsByGuest(int id)
        {
            InitializeComponent();
            _reservationService = new ReservationManager(new EfReservationDal());
            _id = id;
        }
        private int _id;
        private IReservationService _reservationService;

        private void frmReservationByGuest_Load(object sender, EventArgs e)
        {            
            dgvReservationByGuest.DataSource = _reservationService.GetByGuestId(_id);
        }
    }
}
