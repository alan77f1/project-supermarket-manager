namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPN")]
    public partial class ChiTietPN
    {
        [Key]
        [StringLength(10)]
        public string MaPN { get; set; }

        [Required]
        [StringLength(50)]
        public string MaMH { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
