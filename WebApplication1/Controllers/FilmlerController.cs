using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilmlerController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: Filmler
        public ActionResult Index()
        {
            var filmler = db.Filmler.Include(f => f.FilmKalitesi).Include(f => f.FilmKare).Include(f => f.FilmTuru);
            return View(filmler.ToList());
        }

        // GET: Filmler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmler.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Filmler/Create
        public ActionResult Create()
        {
            ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri, "FilmKalitesiID", "FilmKalitesiCozunurluk");
            ViewBag.FilmKareID = new SelectList(db.FilmKareleri, "FilmKareID", "FilmKareSayisi");
            ViewBag.FilmTuruID = new SelectList(db.FilmTurleri, "FilmTuruID", "FilmTuruAdi");
            return View();
        }

        // POST: Filmler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmID,FilmAdi,FilmTuruID,FilmKalitesiID,FilmKareID,Yonetmen,Basrol,Hasilat")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Filmler.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri, "FilmKalitesiID", "FilmKalitesiCozunurluk", film.FilmKalitesiID);
            ViewBag.FilmKareID = new SelectList(db.FilmKareleri, "FilmKareID", "FilmKareSayisi", film.FilmKareID);
            ViewBag.FilmTuruID = new SelectList(db.FilmTurleri, "FilmTuruID", "FilmTuruAdi", film.FilmTuruID);
            return View(film);
        }

        // GET: Filmler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmler.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri, "FilmKalitesiID", "FilmKalitesiCozunurluk", film.FilmKalitesiID);
            ViewBag.FilmKareID = new SelectList(db.FilmKareleri, "FilmKareID", "FilmKareSayisi", film.FilmKareID);
            ViewBag.FilmTuruID = new SelectList(db.FilmTurleri, "FilmTuruID", "FilmTuruAdi", film.FilmTuruID);
            return View(film);
        }

        // POST: Filmler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID,FilmAdi,FilmTuruID,FilmKalitesiID,FilmKareID,Yonetmen,Basrol,Hasilat")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmKalitesiID = new SelectList(db.FilmKaliteleri, "FilmKalitesiID", "FilmKalitesiCozunurluk", film.FilmKalitesiID);
            ViewBag.FilmKareID = new SelectList(db.FilmKareleri, "FilmKareID", "FilmKareSayisi", film.FilmKareID);
            ViewBag.FilmTuruID = new SelectList(db.FilmTurleri, "FilmTuruID", "FilmTuruAdi", film.FilmTuruID);
            return View(film);
        }

        // GET: Filmler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Filmler.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Filmler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Filmler.Find(id);
            db.Filmler.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
