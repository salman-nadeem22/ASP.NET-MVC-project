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
    public class Effective_ParticipationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Effective_Participation
        public ActionResult Index()
        {
            
            var effective_Participations = db.Effective_Participations.Include(e => e.survey);
            
            return View(effective_Participations.ToList());
        }

        public ActionResult YourSurvey()
        {
            ViewBag.name = db.Surveys.Include(e => e.CreatedBy);
            return View(db.Surveys.ToList());
        }

        // GET: Effective_Participation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Effective_Participation effective_Participation = db.Effective_Participations.Find(id);
            if (effective_Participation == null)
            {
                return HttpNotFound();
            }
            return View(effective_Participation);
        }

        // GET: Effective_Participation/Create
        public ActionResult Create()
        {
            ViewBag.surveyId = new SelectList(db.Surveys, "ID", "SurveyName");
            return View();
        }

        // POST: Effective_Participation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Discription,surveyId,EnrollmentNo,UserName")] Effective_Participation effective_Participation)
        {
            if (ModelState.IsValid)
            {
                db.Effective_Participations.Add(effective_Participation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.surveyId = new SelectList(db.Surveys, "ID", "SurveyName", effective_Participation.surveyId);
            return View(effective_Participation);
        }

        // GET: Effective_Participation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Effective_Participation effective_Participation = db.Effective_Participations.Find(id);
            if (effective_Participation == null)
            {
                return HttpNotFound();
            }
            ViewBag.surveyId = new SelectList(db.Surveys, "ID", "SurveyName", effective_Participation.surveyId);
            return View(effective_Participation);
        }

        // POST: Effective_Participation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Discription,surveyId,EnrollmentNo,UserName")] Effective_Participation effective_Participation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(effective_Participation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.surveyId = new SelectList(db.Surveys, "ID", "SurveyName", effective_Participation.surveyId);
            return View(effective_Participation);
        }

        // GET: Effective_Participation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Effective_Participation effective_Participation = db.Effective_Participations.Find(id);
            if (effective_Participation == null)
            {
                return HttpNotFound();
            }
            return View(effective_Participation);
        }

        // POST: Effective_Participation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Effective_Participation effective_Participation = db.Effective_Participations.Find(id);
            db.Effective_Participations.Remove(effective_Participation);
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
