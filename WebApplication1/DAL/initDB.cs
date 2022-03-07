using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class initDB : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            context.FilmKaliteleri.Add(new FilmKalitesi { FilmKalitesiCozunurluk = "480P" });
            context.FilmKaliteleri.Add(new FilmKalitesi { FilmKalitesiCozunurluk = "720P" });
            context.FilmKaliteleri.Add(new FilmKalitesi { FilmKalitesiCozunurluk = "1080P" });
            context.FilmKaliteleri.Add(new FilmKalitesi { FilmKalitesiCozunurluk = "2160P" });
            context.FilmKaliteleri.Add(new FilmKalitesi { FilmKalitesiCozunurluk = "4320P" });
            context.SaveChanges();

            context.FilmKareleri.Add(new FilmKare { FilmKareSayisi = "25" });
            context.FilmKareleri.Add(new FilmKare { FilmKareSayisi = "30" });
            context.FilmKareleri.Add(new FilmKare { FilmKareSayisi = "60" });
            context.FilmKareleri.Add(new FilmKare { FilmKareSayisi = "120" });
            context.SaveChanges();

            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Bilim-Kurgu" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Korku" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Savaş" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Aksiyon" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Macera" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Komedi" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Gerilim" });
            context.FilmTurleri.Add(new FilmTuru { FilmTuruAdi = "Süper Kahraman" });
            context.SaveChanges();

            context.Filmler.Add(new Film { FilmAdi = "Baslangıç", FilmKalitesiID = 5, FilmKareID = 3, FilmTuruID = 1, Basrol = "Leonardo Di Caprio", Yonetmen = "Christhoper Nolan", Hasilat = 825448067 });

            context.Filmler.Add(new Film { FilmAdi = "Batman", FilmKalitesiID = 4, FilmKareID = 2, FilmTuruID = 3, Basrol = "Christian Bale", Yonetmen = "Christoper Nolan" ,Hasilat=32421324});

            context.SaveChanges();
        }

    }
}