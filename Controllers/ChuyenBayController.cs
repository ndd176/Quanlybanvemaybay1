using Quanlybanvemaybay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quanlybanvemaybay1.Models;
using System.Net;

namespace Quanlybanvemaybay1.Controllers
{
    public class ChuyenBayController : Controller
    {
        // GET: ChuyenBay
        public ActionResult Danhsachchuyenbay()
        {
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
            //lay ra danh sach chuyen bay

            List<CHITIETCHUYENBAY> dscb = db.CHITIETCHUYENBAYs.ToList();
            return View(dscb);
        }
        public ActionResult Datve(int id)
        {
            //tim ra doi tuong trong csdl
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
            CHITIETCHUYENBAY chitiet = db.CHITIETCHUYENBAYs.Find(id);
            return View(chitiet);
            
        }
        [HttpGet]
        public ActionResult Details() 
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
            CHITIETCHUYENBAY chitiet = db.CHITIETCHUYENBAYs.Find(id);
            if (chitiet == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }
        // GET: /Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
            CHITIETCHUYENBAY chitiet = db.CHITIETCHUYENBAYs.Find(id);
            if (chitiet == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
            CHITIETCHUYENBAY chitiet = db.CHITIETCHUYENBAYs.Find(id);
            db.CHITIETCHUYENBAYs.Remove(chitiet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //search
        public ActionResult Index(string searchString)
        {
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();

            var chuyenbay = from m in db.CHITIETCHUYENBAYs
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                chuyenbay = chuyenbay.Where(s => s.Sandi.Contains(searchString));
            }

            return View(chuyenbay);
        }
        //ketquakhi filter
        [HttpPost]
        public string Index(FormCollection fc, string searchString)
        {
            return "<h3> From [HttpPost]Index: " + searchString + "</h3>";
        }
        //genre
        public ActionResult Index(string Tensanden, string searchString)
        {
            QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();

            var TensanLst = new List<string>();

            var TensanQry = from d in db.CHITIETCHUYENBAYs
                           orderby d.Sanden
                           select d.Sanden;

            TensanLst.AddRange(TensanQry.Distinct());
            ViewBag.Tensanden = new SelectList(TensanLst);
            var chitiet = from m in db.CHITIETCHUYENBAYs
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                chitiet = chitiet.Where(s => s.Sandi.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(Tensanden))
            {
                chitiet = chitiet.Where(x => x.Sanden == Tensanden);
            }

            return View(chitiet);
        }
        //public ActionResult Search(string searchString)
        //{
        //    QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();

        //    var chitiet = from m in db.CHITIETCHUYENBAYs
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        chitiet = chitiet.Where(s => s.Sandi.Contains(searchString));
        //    }

        //    return View(chitiet);
        //}
        ////ketquatrave sau khi tim kiem
        //[HttpPost]
        //public string Filter(FormCollection fc, string searchString)
        //{
        //    return "<h3> From [HttpPost]Filter: " + searchString + "</h3>";
        //}

        //public ActionResult Search(string Tensanden, string searchString)
        //{
        //    QuanLyVeMayBayEntities1 db = new QuanLyVeMayBayEntities1();
        //    var Sanlist = new List<string>();

        //    var SanQry = from d in db.CHITIETCHUYENBAYs
        //                   orderby d.Sanden
        //                   select d.Sanden;

        //    Sanlist.AddRange(SanQry.Distinct());
        //    ViewBag.Tensanden = new SelectList(Sanlist);

        //    var chuyenbay = from m in db.CHITIETCHUYENBAYs
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        chuyenbay = chuyenbay.Where(s => s.Sandi.Contains(searchString));
        //    }

        //    if (!string.IsNullOrEmpty(Tensanden))
        //    {
        //        chuyenbay = chuyenbay.Where(x => x.Sanden == Tensanden);
        //    }

        //    return View(chuyenbay);
        //}
    }
}