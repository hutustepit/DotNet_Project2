using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstModelProject.Models;

namespace FirstModelProject.Controllers
{
    public class GlobalsController : Controller
    {
        private FirstModelProjectContext db = new FirstModelProjectContext();

        // GET: Globals
        public ActionResult Index()
        {
            return View(db.Globals.ToList());
        }

        // GET: Globals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Globals globals = db.Globals.Find(id);
            if (globals == null)
            {
                return HttpNotFound();
            }
            return View(globals);
        }

		public Globals  GetById(int ID)
		{
			Globals globals = db.Globals.Find(ID);
			return globals;
		}

        // GET: Globals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Globals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EurToRon,EurToDol")] Globals globals)
        {
            if (ModelState.IsValid)
            {
                db.Globals.Add(globals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(globals);
        }

        // GET: Globals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Globals globals = db.Globals.Find(id);
            if (globals == null)
            {
                return HttpNotFound();
            }
            return View(globals);
        }

        // POST: Globals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EurToRon,EurToDol")] Globals globals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(globals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(globals);
        }

        // GET: Globals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Globals globals = db.Globals.Find(id);
            if (globals == null)
            {
                return HttpNotFound();
            }
            return View(globals);
        }

        // POST: Globals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Globals globals = db.Globals.Find(id);
            db.Globals.Remove(globals);
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
