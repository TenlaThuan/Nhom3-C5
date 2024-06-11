using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM2C5API.Models
{
    public class TaiKhoan
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdND {  get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TenDN { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MatKhau { get; set; }
        
        public int Role { get; set; }
        public VaiTro VaiTro { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
