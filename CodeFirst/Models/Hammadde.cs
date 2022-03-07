using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Hammadde
    {
        public int HammaddeID { get; set; }
        public string HammaddeAdi { get; set; }

        public ICollection<Mobilya> Mobilyalar { get; set; }
    }
}