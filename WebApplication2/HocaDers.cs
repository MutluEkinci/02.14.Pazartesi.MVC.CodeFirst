namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HocaDers
    {
        public int HocaDersID { get; set; }

        public int? HocaID { get; set; }

        public int? DersID { get; set; }

        public virtual Ders Ders { get; set; }

        public virtual Hoca Hoca { get; set; }
    }
}
