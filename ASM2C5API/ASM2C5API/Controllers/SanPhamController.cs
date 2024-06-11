using ASM2C5API.Models;
using ASM2C5API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASM2C5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPham _sanPham;
        public SanPhamController(ISanPham sanPham)
        {
            _sanPham = sanPham; 
        }
        [HttpGet]
        public IEnumerable<SanPham> GetSanPhams()
        {
            return _sanPham.SanPhams();
        }
        [HttpPost]
        public SanPham Post(SanPham sanPham)
        {
            return _sanPham.AddSanPham(new SanPham
            {
                TenSP = sanPham.TenSP,
                Mota = sanPham.Mota,
                Gia = sanPham.Gia,
                SoLuong = sanPham.SoLuong,
                HinhAnh = sanPham.HinhAnh,
                IdDanhMuc = sanPham.IdDanhMuc,
                MaChiTietHoaDon = sanPham.MaChiTietHoaDon,
            });
        }
        [HttpGet("{id}")]
        public ActionResult<SanPham> GetOne(int id)
        {
            if (id == 0)
                return BadRequest("Id is null");
            return Ok(_sanPham.SanPham(id));
        }
        [HttpPut("{id}")]
        public SanPham Update(SanPham sanPham, int id)
        {
            return _sanPham.UpdateSanPham(sanPham, id);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _sanPham.DeleteSanPham(id);
            return NoContent();
        }
    }
}
