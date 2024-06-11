using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM2C5API.Models
{
    public class ChiTietHoaDon
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChiTietHoaDon {  get; set; }
        public int SoLuong {  get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }

        public ICollection<SanPham> SanPham { get; set; }

    }
}
