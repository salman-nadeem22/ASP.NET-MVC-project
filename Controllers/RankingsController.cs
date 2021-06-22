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
    public class RankingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rankings
        public ActionResult Index()
        {
            return View(db.Rankings.ToList());
        }

        // GET: Rankings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ranking ranking = db.Rankings.Find(id);
            if (ranking == null)
            {
                return HttpNotFound();
            }
            return View(ranking);
        }

        // GET: Rankings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rankings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,SurveyName,SurveyId,StudentRollNo,Rank,Prize")] Ranking ranking)
        {
            if (ModelState.IsValid)
            {
                db.Rankings.Add(ranking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ranking);
        }

        // GET: Rankings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ranking ranking = db.Rankings.Find(id);
            if (ranking == null)
            {
                return HttpNotFound();
            }
            return View(ranking);
        }

        // POST: Rankings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,SurveyName,SurveyId,StudentRollNo,Rank,Prize")] Ranking ranking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ranking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ranking);
        }

        // GET: Rankings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ranking ranking = db.Rankings.Find(id);
            if (ranking == null)
            {
                return HttpNotFound();
            }
            return View(ranking);
        }

        // POST: Rankings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ranking ranking = db.Rankings.Find(id);
            db.Rankings.Remove(ranking);
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
