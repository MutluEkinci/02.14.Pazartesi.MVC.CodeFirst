using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirst.Models;
namespace CodeFirst.DAL

{
    public class initDB : DropCreateDatabaseAlways<MobilyaContext>
    {
        protected override void Seed(MobilyaContext context)
        {
            context.Hammaddeler.Add(new Hammadde { HammaddeAdi = "Sunta" });
            context.Hammaddeler.Add(new Hammadde { HammaddeAdi = "Ceviz" });
            context.Hammaddeler.Add(new Hammadde { HammaddeAdi = "Meşe" });
            context.SaveChanges();

            context.MobilyaTurleri.Add(new MobilyaTuru { MobilyaTuruAdi = "Yemek Odası" });
            context.MobilyaTurleri.Add(new MobilyaTuru { MobilyaTuruAdi = "Oturma Odası" });
            context.SaveChanges();

            //context.Mobilyalar.Add(new Mobilya {MobilyaAdi="6'lı Yemek Odası Takımı",HammaddeID=2,MobilyaTuruID=1 });
            //context.Mobilyalar.Add(new Mobilya {MobilyaAdi="12'lı Yemek Odası Takımı",HammaddeID=3,MobilyaTuruID=1 });
            //context.Mobilyalar.Add(new Mobilya {MobilyaAdi="2'li Koltuk",HammaddeID=2,MobilyaTuruID=2 });
            //context.SaveChanges();
        }
    }
}