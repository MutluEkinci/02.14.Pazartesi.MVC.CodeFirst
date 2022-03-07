using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SinemaController : Controller
    {
        // GET: Sinema
        FilmContext db = new FilmContext();
        public ActionResult Index()
        {

            return View(db.Filmler.ToList());
        }
        public ActionResult Create()
        {
            ViewBag.FilmTuruID = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
            ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
            ViewBag.FilmKareID = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Filmler.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.FilmTuruID = new SelectList(db.FilmTurleri.ToList(), "FilmTuruID", "FilmTuruAdi");
                ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri.ToList(), "FilmKalitesiID", "FilmKalitesiCozunurluk");
                ViewBag.FilmKareID = new SelectList(db.FilmKareleri.ToList(), "FilmKareID", "FilmKareSayisi");
                return View();
            }
        }
    }
}