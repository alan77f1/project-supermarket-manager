namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
            ChiTietPNs = new HashSet<ChiTietPN>();
        }

        [Key]
        [StringLength(50)]
        public string MaMH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMH { get; set; }

       /* [Required]
        [StringLength(20)]
        public string LoaiMH { get; set; }*/

        [Required]
        [StringLength(10)]
        public string DonVi { get; set; }

        public int GiaBan { get; set; }

        public int SoLuong { get; set; }

        public long? GiaGoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPN> ChiTietPNs { get; set; }

        public virtual DonViTinh DonViTinh { get; set; }

        public virtual QuayHang QuayHang { get; set; }
        public MatHang(DataRow row)
        {
            this.MaMH = row["MaMH"].ToString();
            this.TenMH = row["TenMH"].ToString();
            this.DonVi = row["DonVi"].ToString();
            this.GiaBan = (int)row["GiaBan"];
            this.SoLuong = (int)row["SoLuong"];
            
        }
    }
}
