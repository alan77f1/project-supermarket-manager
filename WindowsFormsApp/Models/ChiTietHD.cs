namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaMH { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
