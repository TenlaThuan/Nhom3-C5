using System;
using System.Collections.Generic;
using ASM2C5API.Data;
using ASM2C5API.Models;
namespace ASM2C5API.Service
{
    public class SanPhamm : ISanPham
    {
        private readonly MyDbcontext _context;
        public SanPhamm(MyDbcontext context)
        {
            _context = context;
        }

        public SanPham AddSanPham(SanPham sanPham)
        {
            _context.Add(sanPham);
            _context.SaveChanges();
            return sanPham;
        }

        public void DeleteSanPham(int id)
        {
            var sanphamm = _context.SanPhams.Find(id);
            _context.SanPhams.Remove(sanphamm);
            _context.SaveChanges();
        }

        public SanPham SanPham(int id)
        {
            var sanphamm = _context.SanPhams.Find(id);
            if (sanphamm == null)
                return null;
            return sanphamm;
        }

        public IEnumerable<SanPham> SanPhams()
        {
            return _context.SanPhams;
        }

        public SanPham UpdateSanPham(SanPham sanPham, int id)
        {
            var sanphamm = _context.SanPhams.Find(id);
            sanphamm.TenSP = sanPham.TenSP;
            sanphamm.Mota = sanPham.Mota;
            sanphamm.Gia = sanPham.Gia;
            sanphamm.SoLuong = sanPham.SoLuong;
            sanphamm.HinhAnh = sanPham.HinhAnh;
            sanphamm.IdDanhMuc = sanPham.IdDanhMuc;
            sanphamm.MaChiTietHoaDon = sanPham.MaChiTietHoaDon;
            return sanphamm;
        }
    }
}
