using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class MobilyaTuru
    {
        public int Id { get; set; }
        public string MobilyaTuruAdi { get; set; }
        public ICollection<Mobilya> Mobilyalar { get; set; }
    }
}