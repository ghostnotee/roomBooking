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
    public partial class frmRoomEdit : Form
    {
        public frmRoomEdit()
        {
            InitializeComponent();
            _roomService = new RoomManager(new EfRoomDal());
        }

        private IRoomService _roomService;

        private void frmRoomEdit_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
        {
            dgvEditAllRooms.DataSource = _roomService.GetAll();
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            _roomService.Add(new Room()
            {
                RoomTypeId = Convert.ToInt32(dgvEditAllRooms.SelectedRows[0].Cells[1].Value),
                Number = Convert.ToByte(dgvEditAllRooms.SelectedRows[0].Cells[2].Value),
                Name = dgvEditAllRooms.SelectedRows[0].Cells[3].Value.ToString()
            });
            MessageBox.Show("Sisteme yeni oda eklendi!");
            LoadRooms();
        }

        private void dgwEditAllRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoomType.Text = dgvEditAllRooms.SelectedRows[0].Cells[1].Value.ToString();
            txtRoomNumber.Text = dgvEditAllRooms.SelectedRows[0].Cells[2].Value.ToString();
            txtRoomName.Text = dgvEditAllRooms.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            _roomService.Update(new Room()
            {
                Id = Convert.ToInt32(dgvEditAllRooms.SelectedRows[0].Cells[0].Value),
                RoomTypeId = int.Parse(txtRoomType.Text),
                Number = Convert.ToByte(txtRoomNumber.Text),
                Name = txtRoomName.Text,
                Status = Convert.ToInt32(dgvEditAllRooms.SelectedRows[0].Cells[3].Value)
            });
            MessageBox.Show("Seçilen odanın özellikleri güncellendi");
            LoadRooms();
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            _roomService.Delete(new Room { Id = Convert.ToInt32(dgvEditAllRooms.CurrentRow.Cells[0].Value) });  // PKey'e göre uçurur.
            LoadRooms();
            MessageBox.Show("Oda Sistemden Silindi");
        }
    }
}
