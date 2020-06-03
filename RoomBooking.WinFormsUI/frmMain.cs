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
    public partial class frmMain : Form
    {

        private IRoomService _roomService;


        public frmMain()
        {
            InitializeComponent();
            _roomService = new RoomManager(new EfRoomDal());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ListRooms();
        }

        public void ListRooms(string roomName = "")
        {
            flpRoomList.Controls.Clear();
            var allRooms = _roomService.GetAll();
            for (int i = 0; i < _roomService.GetAll().Count; i++)
            {
                if (roomName == "" || allRooms[i].Name.IndexOf(roomName)>-1)
                {
                    RoomButton rb = new RoomButton(allRooms[i]);
                    flpRoomList.Controls.Add(rb);
                }
            }
        }
      
        private void btnGuests_Click(object sender, EventArgs e)
        {
            frmGuests frmGuests = new frmGuests();
            frmGuests.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            frmReservationEdit reservationEdit = new frmReservationEdit();
            reservationEdit.ShowDialog();
            ListRooms(txtFilter.Text);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRoomEdit roomEdit = new frmRoomEdit();
            roomEdit.ShowDialog();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            ListRooms(txtFilter.Text);
        }

        private void tmrMinute_Tick(object sender, EventArgs e)
        {
            foreach(RoomButton btn in flpRoomList.Controls)
            {
                btn.UpdateInfo();
            }
        }
    }
}
