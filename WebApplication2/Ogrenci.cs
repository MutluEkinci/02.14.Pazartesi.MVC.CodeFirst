namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ogrenci")]
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            OgrDers = new HashSet<OgrDers>();
        }

        [Key]
        public int OgrID { get; set; }

        [StringLength(6)]
        public string OgrNo { get; set; }

        [Required]
        [StringLength(20)]
        public string OgrAd { get; set; }

        [Required]
        [StringLength(20)]
        public string OgrSoyad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrDers> OgrDers { get; set; }
    }
}
