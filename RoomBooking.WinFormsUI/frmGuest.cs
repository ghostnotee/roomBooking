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

using RoomBooking.Entites.Concrete;

namespace RoomBooking.WinFormsUI
{
    public partial class frmGuest : Form
    {
        Guest _guestToEdit;

        public frmGuest(Guest guest = null)
        {
            InitializeComponent();
            _guestToEdit = guest;
            _guestService = new GuestManager(new EfGuestDal());
        }

        private IGuestService _guestService;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_guestToEdit == null)
            {
                Guest guest = new Guest();
                guest.TCIdNo = txtID.Text;
                guest.FirstName = txtFirstName.Text;
                guest.LastName = txtLastName.Text;
                _guestService.Add(guest);
                MessageBox.Show("Kayıt Ekleme Başarılı");
                
                this.Close();
            }
            else
            {
                _guestToEdit.TCIdNo = txtID.Text;
                _guestToEdit.FirstName = txtFirstName.Text;
                _guestToEdit.LastName = txtLastName.Text;
                _guestService.Update(_guestToEdit);
                MessageBox.Show("Kayıt Düzenleme Başarılı");
                Close();
            }
        }

        private void frmGuest_Load(object sender, EventArgs e)
        {
            if(_guestToEdit != null)
            {
                this.Text = _guestToEdit.FirstName + " " + _guestToEdit.LastName;
                txtID.Text = _guestToEdit.TCIdNo;
                txtLastName.Text = _guestToEdit.LastName;
                txtFirstName.Text = _guestToEdit.FirstName;
            }
        }
    }
}
