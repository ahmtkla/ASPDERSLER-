using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proje3.Models.Entity;

namespace proje3.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERİLER.ToList();
            return View(degerler);
        }   
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
    [HttpPost]
    public ActionResult YeniMusteri(TBLMUSTERİLER p1)
        {
            db.TBLMUSTERİLER.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}