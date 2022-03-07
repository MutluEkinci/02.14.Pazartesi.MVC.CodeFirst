namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OgrDers
    {
        public int OgrDersID { get; set; }

        public int? OgrID { get; set; }

        public int? DersID { get; set; }

        public decimal? Vize { get; set; }

        public decimal? Final { get; set; }

        public decimal? Ortalama { get; set; }

        public virtual Ders Ders { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
    }
}
