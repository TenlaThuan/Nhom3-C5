using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM2C5API.Models
{
    public class SanPham
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSP { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TenSP { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Mota {  get; set; }
        public float Gia { get; set; }

        public int SoLuong { get; set; }

        public string HinhAnh { get; set; }
        public int IdDanhMuc { get; set; }
        public int MaChiTietHoaDon {  get; set; }
        public DanhMuc DanhMuc { get; set; }
        public ChiTietHoaDon ChiTietHoaDon { get; set; }
        

    }
}
