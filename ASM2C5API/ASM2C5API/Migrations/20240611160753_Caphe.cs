using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM2C5API.Migrations
{
    public partial class Caphe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    MaChiTietHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.MaChiTietHoaDon);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    IdDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loai = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.IdDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "VaiTros",
                columns: table => new
                {
                    Role = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTros", x => x.Role);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gia = table.Column<float>(type: "real", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDanhMuc = table.Column<int>(type: "int", nullable: false),
                    MaChiTietHoaDon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSP);
                    table.ForeignKey(
                        name: "FK_SanPhams_ChiTietHoaDons_MaChiTietHoaDon",
                        column: x => x.MaChiTietHoaDon,
                        principalTable: "ChiTietHoaDons",
                        principalColumn: "MaChiTietHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucs_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "DanhMucs",
                        principalColumn: "IdDanhMuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    IdND = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.IdND);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_VaiTros_Role",
                        column: x => x.Role,
                        principalTable: "VaiTros",
                        principalColumn: "Role",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IdND = table.Column<int>(type: "int", nullable: false),
                    MaChiTietHoaDon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_ChiTietHoaDons_MaChiTietHoaDon",
                        column: x => x.MaChiTietHoaDon,
                        principalTable: "ChiTietHoaDons",
                        principalColumn: "MaChiTietHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_TaiKhoans_IdND",
                        column: x => x.IdND,
                        principalTable: "TaiKhoans",
                        principalColumn: "IdND",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdND",
                table: "HoaDons",
                column: "IdND");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaChiTietHoaDon",
                table: "HoaDons",
                column: "MaChiTietHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IdDanhMuc",
                table: "SanPhams",
                column: "IdDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_MaChiTietHoaDon",
                table: "SanPhams",
                column: "MaChiTietHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_Role",
                table: "TaiKhoans",
                column: "Role",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "DanhMucs");

            migrationBuilder.DropTable(
                name: "VaiTros");
        }
    }
}
