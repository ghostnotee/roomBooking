using RoomBooking.Entites.Absract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Entites.Concrete
{
    public class Reservation:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Konuk")]
        public int GuestId { get; set; }
        [DisplayName("Oda Numarası")]
        public int RoomId { get; set; }
        [DisplayName("Rezervasyon Başlangıç")]
        public DateTime DateIn { get; set; }
        [DisplayName("Rezervasyon Çıkış")]
        public DateTime DateOut { get; set; }
        [DisplayName("Rezervasyon Başlangıç")]
        public int Status { get; set; }
        public int? MadeBy { get; set; }
        public int? PersonelId { get; set; }
        [DisplayName("Giriş Tarihi")]
        public DateTime? CheckIn { get; set; }
        [DisplayName("Çıkış Tarihi")]
        public DateTime? CheckOut { get; set; }
        [DisplayName("Not")]
        public string Note { get; set; }
    }
}
