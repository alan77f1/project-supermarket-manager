namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        [StringLength(10)]
        public string MaPN { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNV { get; set; }

        public virtual ChiTietPN ChiTietPN { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
