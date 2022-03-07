using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    [Table("Mobilyalar")]
    public class Mobilya
    {
        //Id ya da entity+Id ise otomatik olarak primary key olarak kabul eder 
        [Key]
        public int MobilyaNO { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string MobilyaAdi { get; set; }
        public int MobilyaTuruID { get; set; }
        public int HammaddeID { get; set; }
        public decimal Fiyat { get; set; }


        //Navigation Prop.
        public MobilyaTuru MobilyaTuru { get; set; }
        //public ICollection<MobilyaTuru> MobilyaTurleri { get; set; } çoka çok ilişki için
        public Hammadde Hammadde { get; set; }
    }
}