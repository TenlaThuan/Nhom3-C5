using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM2C5API.Models
{
    public class DanhMuc
    {
   
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDanhMuc { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Loai {  get; set; }
        public ICollection<SanPham> SanPham { get; set; }

    }
}
