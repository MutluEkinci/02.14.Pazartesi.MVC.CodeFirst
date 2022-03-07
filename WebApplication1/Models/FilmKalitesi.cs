using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("FilmKaliteleri")]
    public class FilmKalitesi
    {
        public int FilmKalitesiID { get; set; }
        [Display(Name ="Çözünürlük")]
        public string FilmKalitesiCozunurluk { get; set; }


        public ICollection<Film> Filmler { get; set; }
    }
}