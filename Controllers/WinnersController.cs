using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AptechProject.Models;

namespace AptechProject.Controllers
{
    public class WinnersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Winners
        
        public ActionResult Index()
        {
            return View(db.Winners.ToList());
        }

        // GET: Winners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // GET: Winners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Winners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameOfWinner,StudentRollNo,SurveyName")] Winners winners)
        {
            if (ModelState.IsValid)
            {
                db.Winners.Add(winners);
                db.SaveChanges();
                return RedirectToAction("Index", "Surveys");
            }

            return View(winners);
        }

        // GET: Winners/Edit/5
        [Authorize(Roles = "admin,faculty")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // POST: Winners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameOfWinner,StudentRollNo,SurveyName")] Winners winners)
        {
            if (ModelState.IsValid)
            {
                db.Entry(winners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(winners);
        }

        // GET: Winners/Delete/5
        [Authorize(Roles = "admin,faculty")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // POST: Winners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Winners winners = db.Winners.Find(id);
            db.Winners.Remove(winners);
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
