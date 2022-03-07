namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoca")]
    public partial class Hoca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoca()
        {
            HocaDers = new HashSet<HocaDers>();
        }

        public int HocaID { get; set; }

        [StringLength(6)]
        public string HocaNo { get; set; }

        [Required]
        [StringLength(20)]
        public string HocaAd { get; set; }

        [Required]
        [StringLength(20)]
        public string HocaSoyad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocaDers> HocaDers { get; set; }
    }
}
