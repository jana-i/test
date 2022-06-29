using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using new_proekt.Models;

namespace new_proekt.Controllers
{
    
    public class clothesController : Controller
    {
        
        private ApplicationDbContext db = new ApplicationDbContext();
        //[AllowAnonymous]
        // GET: clothes
        public ActionResult Index()
        {
            return View(db.clothes.ToList());
        }
        //[AllowAnonymous]
        // GET: clothes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clothes clothes = db.clothes.Find(id);
            if (clothes == null)
            {
                return HttpNotFound();
            }
            return View(clothes);
        }

        // GET: clothes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clothes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,ItemCode,Description,ImageURL")] clothes clothes)
        {
            if (ModelState.IsValid)
            {
                db.clothes.Add(clothes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clothes);
        }
        [Authorize]
        // GET: clothes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clothes clothes = db.clothes.Find(id);
            if (clothes == null)
            {
                return HttpNotFound();
            }
            return View(clothes);
        }

        // POST: clothes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,ItemCode,Description,ImageURL")] clothes clothes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clothes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clothes);
        }

       
        public ActionResult Delete(int id)
        {
            clothes clothes = db.clothes.Find(id);
            db.clothes.Remove(clothes);
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
