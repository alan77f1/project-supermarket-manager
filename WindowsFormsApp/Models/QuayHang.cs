namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuayHang")]
    public partial class QuayHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuayHang()
        {
            MatHangs = new HashSet<MatHang>();
        }

        [Key]
        [StringLength(20)]
        public string MaQH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenQH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
