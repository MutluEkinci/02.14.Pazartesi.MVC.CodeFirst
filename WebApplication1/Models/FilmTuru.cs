using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("FilmTurleri")]
    public class FilmTuru
    {
        public int FilmTuruID { get; set; }
        [Display(Name ="Türü")]
        public string FilmTuruAdi { get; set; }


        public ICollection<Film> Filmler { get; set; }
    }
}