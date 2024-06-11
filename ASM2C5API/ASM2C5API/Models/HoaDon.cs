using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM2C5API.Models
{
    public class HoaDon
    {
 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDon {  get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayTao { get; set; }
        public float TongTien {  get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TrangThai { get; set; }
        public int IdND {  get; set; }
        public int MaChiTietHoaDon { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public ChiTietHoaDon ChiTietHoaDon { get; set; }
    }
}
