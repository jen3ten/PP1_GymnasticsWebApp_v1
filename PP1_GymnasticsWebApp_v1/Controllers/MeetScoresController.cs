using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PP1_GymnasticsWebApp_v1.Models;

namespace PP1_GymnasticsWebApp_v1.Controllers
{
    public class MeetScoresController : Controller
    {
        private PP1_GymnasticsWebApp_v1Context db = new PP1_GymnasticsWebApp_v1Context();

        // GET: MeetScores
        public ActionResult Index()
        {
            return View(db.MeetScores.ToList());
        }

        // GET: MeetScores/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetScores meetScores = db.MeetScores.Find(id);
            if (meetScores == null)
            {
                return HttpNotFound();
            }
            return View(meetScores);
        }

        // GET: MeetScores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeetScores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetDate,Name,Location,Vault,Bar,Beam,Floor,Overall")] MeetScores meetScores)
        {
            if (ModelState.IsValid)
            {
                db.MeetScores.Add(meetScores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meetScores);
        }

        // GET: MeetScores/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetScores meetScores = db.MeetScores.Find(id);
            if (meetScores == null)
            {
                return HttpNotFound();
            }
            return View(meetScores);
        }

        // POST: MeetScores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetDate,Name,Location,Vault,Bar,Beam,Floor,Overall")] MeetScores meetScores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetScores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meetScores);
        }

        // GET: MeetScores/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetScores meetScores = db.MeetScores.Find(id);
            if (meetScores == null)
            {
                return HttpNotFound();
            }
            return View(meetScores);
        }

        // POST: MeetScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            MeetScores meetScores = db.MeetScores.Find(id);
            db.MeetScores.Remove(meetScores);
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
