using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM2C5API.Models
{
    public class VaiTro
    {
        [Key]
        
        public int Role { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TenDN { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
