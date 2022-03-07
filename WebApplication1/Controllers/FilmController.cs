using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        FilmContext db = new FilmContext();
        public ActionResult Index(string ara, int sayfa = 0)
        {
            int adet = 1;
            ViewBag.Sayi = (db.Filmler.ToList().Count() / adet);
            if (ara == null)
            {
                if (sayfa == 0 || sayfa == null)
                {
                    return View(db.Filmler.ToList().Take(adet));
                }
                else
                {
                    return View(db.Filmler.ToList().Skip(sayfa * adet).Take(adet));
                }
            }
            else
            {
                return View(db.Filmler.Where(x => x.FilmAdi.Contains(ara)).ToList());
            }
        }
        //public ActionResult Index(string ara, int? sayi)
        //{
        //    var liste = db.Filmler.ToList();

        //    int adet = 3;
        //    ViewBag.SayfaSayi = liste.Count() / adet;

        //    return View(liste);

        //}
        public ActionResult Index2(string ara)
        {
            if (ara == null)
            {
                return View(db.Filmler.Skip(1).Take(1).ToList());
            }
            else
            {
                return View(db.Filmler.Where(x => x.FilmAdi.Contains(ara)).ToList());
            }

        }

        public ActionResult VeriKaydet()
        {
            //ViewBag Kullanımı Combobox aka dropdownlist için

            ViewBag.Turler = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
            ViewBag.Kaliteler = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
            ViewBag.Kareler = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");

            return View();
        }
        [HttpPost]
        public ActionResult VeriKaydet(Film film)
        {
            db.Filmler.Add(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult VeriKaydetVM()
        {
            //ViewModel Kullanımı Combobox aka dropdownlist için
            Film_VM filmVW = new Film_VM();
            filmVW.Turler = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
            filmVW.Kaliteler = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
            filmVW.Kareler = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");

            return View(filmVW);
        }
        [HttpPost]
        public ActionResult VeriKaydetVM(Film_VM filmVM)
        {
            if (ModelState.IsValid)
            {
                db.Filmler.Add(filmVM.Film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Film_VM filmVW = new Film_VM();
                filmVW.Turler = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
                filmVW.Kaliteler = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
                filmVW.Kareler = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");
                return View(filmVW);
            }
                
        }
        public ActionResult VeriGuncelle(int id)
        {
            Film_VM filmVM = new Film_VM();
            //var film= db.Filmler.Where(x => x.FilmID == id).FirstOrDefault();
            //db.SaveChanges();
            filmVM.Turler = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
            filmVM.Kaliteler = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
            filmVM.Kareler = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");
            filmVM.Film = db.Filmler.Find(id);
            db.SaveChanges();
            return View(filmVM);
        }
        [HttpPost]
        public ActionResult VeriGuncelle(Film film)
        {
            db.Entry<Film>(film).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult VeriSil(int? id)
        {
            var film = db.Filmler.Find(id);
            db.Entry<Film>(film).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult VeriAra(string FilmAdi)
        {
            db.Filmler.Where(x => x.FilmAdi == FilmAdi).FirstOrDefault();
            db.SaveChanges();
            return View("Index");
        }

    }
}