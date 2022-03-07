using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication1.CustomValidators;
namespace WebApplication1.Models
{
    [Table("Filmler")]
    public class Film
    {
        public int FilmID { get; set; }
        [CustomFilmName(ErrorMessage = "Film adı '@' içeremez!")]
        [Required(ErrorMessage = "Boş geçemezsiniz!")]
        [Display(Name ="Film Adı")]
        public string FilmAdi { get; set; }
        [Display(Name ="Film Türü")]
        public int FilmTuruID { get; set; }
        [Display(Name ="Kalite")]
        public int FilmKalitesiID { get; set; }
        [Display(Name ="Kare Sayısı")]
        public int FilmKareID { get; set; }
        [Display(Name ="Yönetmen")]
        public string Yonetmen { get; set; }
        [Display(Name ="Başrol")]
        public string Basrol { get; set; }

        [Required(ErrorMessage = "Boş geçemezsiniz!")]
        [Range(0, 5000000000, ErrorMessage = "0-5.000.000.000 Arasında bir değer girilmeli"),]
        //[RegularExpression("[0-9]", ErrorMessage = "Lütfen sayı giriniz!")]
        [Display(Name ="Hasılat")]
        public decimal Hasilat { get; set; }


        public virtual FilmTuru FilmTuru { get; set; }
        public virtual FilmKalitesi FilmKalitesi { get; set; }
        public virtual FilmKare FilmKare { get; set; }
    }
}