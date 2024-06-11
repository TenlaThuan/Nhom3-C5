using System.Collections;
using ASM2C5API.Models;
using System.Collections.Generic;
namespace ASM2C5API.Service
{
    public interface ISanPham
    {
        public IEnumerable<SanPham> SanPhams();
        public SanPham SanPham(int id);
        public SanPham AddSanPham(SanPham sanPham);
        public SanPham UpdateSanPham(SanPham sanPham, int id);
        public void DeleteSanPham(int id);
    }
}
