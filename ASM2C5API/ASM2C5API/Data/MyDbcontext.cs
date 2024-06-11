
using ASM2C5API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASM2C5API.Data
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {

        }
        public DbSet< DanhMuc> DanhMucs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }

        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMuc>().HasKey(a => a.IdDanhMuc);
            modelBuilder.Entity<SanPham>().HasKey(b => b.IdSP);

            modelBuilder.Entity<TaiKhoan>().HasKey(d => d.IdND);
            modelBuilder.Entity<HoaDon>().HasKey(d => d.MaHoaDon);
            modelBuilder.Entity<ChiTietHoaDon>().HasKey(c => c.MaChiTietHoaDon);

            modelBuilder.Entity<SanPham>()
               .HasOne(s => s.DanhMuc)
               .WithMany(d => d.SanPham)
               .HasForeignKey(s => s.IdDanhMuc);
            modelBuilder.Entity<SanPham>()
                .HasOne(s => s.ChiTietHoaDon)
                .WithMany(d => d.SanPham)
                .HasForeignKey(e => e.MaChiTietHoaDon);
            modelBuilder.Entity<HoaDon>()
              .HasOne(s => s.ChiTietHoaDon)
              .WithMany(d => d.HoaDon)
              .HasForeignKey(e => e.MaChiTietHoaDon);
            modelBuilder.Entity<HoaDon>()
                .HasOne(s => s.TaiKhoan)
                .WithMany(d => d.HoaDon)
                .HasForeignKey(e => e.IdND);
            modelBuilder.Entity<TaiKhoan>()
                .HasOne(s => s.VaiTro)
                .WithOne(d => d.TaiKhoan)
                .HasForeignKey<TaiKhoan>(e => e.Role);


        }
    }
}
