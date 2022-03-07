using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("FilmKareleri")]
    public class FilmKare
    {
        public int FilmKareID { get; set; }
        [Display(Name ="Kare Sayısı")]
        public string FilmKareSayisi { get; set; }


        public ICollection<Film> Filmler { get; set; }
    }
}