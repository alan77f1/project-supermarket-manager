namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietCLV")]
    public partial class ChiTietCLV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaCLV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLam { get; set; }

        public virtual CaLamViec CaLamViec { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
