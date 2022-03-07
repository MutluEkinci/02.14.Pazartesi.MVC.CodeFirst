using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.DAL;
namespace CodeFirst.Controllers
{
    public class MobilyaController : Controller
    {
        // GET: Mobilya
        MobilyaContext db = new MobilyaContext();
        public ActionResult Index()
        {
            return View(db.Mobilyalar.ToList());
        }
    }
}