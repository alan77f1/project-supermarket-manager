using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp.Models
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<CaLamViec> CaLamViecs { get; set; }
        public virtual DbSet<ChiTietCLV> ChiTietCLVs { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChiTietPN> ChiTietPNs { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<QuayHang> QuayHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaLamViec>()
                .HasMany(e => e.ChiTietCLVs)
                .WithRequired(e => e.CaLamViec)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietPN>()
                .Property(e => e.MaPN)
                .IsFixedLength();

            modelBuilder.Entity<DonViTinh>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.DonViTinh)
                .HasForeignKey(e => e.DonVi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.LoaiMH)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.DonVi)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ChiTietPNs)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenHienThi)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.ChiTietCLVs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPN)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .HasOptional(e => e.ChiTietPN)
                .WithRequired(e => e.PhieuNhap);

            modelBuilder.Entity<QuayHang>()
                .Property(e => e.MaQH)
                .IsUnicode(false);

            modelBuilder.Entity<QuayHang>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.QuayHang)
                .HasForeignKey(e => e.LoaiMH)
                .WillCascadeOnDelete(false);
        }
    }
}
