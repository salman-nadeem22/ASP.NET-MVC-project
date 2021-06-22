using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AptechProject.Models;
using Microsoft.AspNet.Identity;

namespace AptechProject.Controllers
{
    public class SurveysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        // GET: Surveys
        public ActionResult Index()
        {
            return View(db.Surveys.ToList());
        }

        [Authorize]
        public ActionResult Search(string searchBox)
        {
            var surveys = (from s in db.Surveys
                           where s.SurveyName.Contains(searchBox)
                           || s.CreatedBy.Contains(searchBox)
                           select s).ToList();

            return View("Index", surveys);
        }

        [Authorize]
        // GET: Surveys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        [Authorize]
        // GET: Surveys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Surveys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SurveyName,CreatedBy,StudentID,Survey_1,Survey_1_option_1,Survey_1_option_2,Survey_1_option_3,Survey_2,Survey_2_option_1,Survey_2_option_2,Survey_2_option_3,Survey_3,Survey_3_option_1,Survey_3_option_2,Survey_3_option_3,Survey_4,Survey_4_option_1,Survey_4_option_2,Survey_4_option_3,Survey_5,Survey_5_option_1,Survey_5_option_2,Survey_5_option_3,dateTime")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Surveys.Add(survey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(survey);
        }

        [Authorize]
        // GET: Surveys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SurveyName,CreatedBy,StudentID,Survey_1,Survey_1_option_1,Survey_1_option_2,Survey_1_option_3,Survey_2,Survey_2_option_1,Survey_2_option_2,Survey_2_option_3,Survey_3,Survey_3_option_1,Survey_3_option_2,Survey_3_option_3,Survey_4,Survey_4_option_1,Survey_4_option_2,Survey_4_option_3,Survey_5,Survey_5_option_1,Survey_5_option_2,Survey_5_option_3,dateTime")] Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }
        [Authorize]
        // GET: Surveys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Survey survey = db.Surveys.Find(id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Survey survey = db.Surveys.Find(id);
            db.Surveys.Remove(survey);
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
