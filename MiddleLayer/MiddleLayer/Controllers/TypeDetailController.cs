using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiddleLayer.Models;

namespace MiddleLayer.Controllers
{
    public class TypeDetailController : Controller
    {
        private RetailEntities db = new RetailEntities();

        // GET: TypeDetail
        public ActionResult Index()
        {
            return View(db.TypeDetails.ToList());
        }

        // GET: TypeDetail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            if (typeDetail == null)
            {
                return HttpNotFound();
            }
            return View(typeDetail);
        }

        // GET: TypeDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeDetail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeId,TypeCode,TypeName,DetailName")] TypeDetail typeDetail)
        {
            if (ModelState.IsValid)
            {
                db.TypeDetails.Add(typeDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeDetail);
        }

        // GET: TypeDetail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            if (typeDetail == null)
            {
                return HttpNotFound();
            }
            return View(typeDetail);
        }

        // POST: TypeDetail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeId,TypeCode,TypeName,DetailName")] TypeDetail typeDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeDetail);
        }

        // GET: TypeDetail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            if (typeDetail == null)
            {
                return HttpNotFound();
            }
            return View(typeDetail);
        }

        // POST: TypeDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeDetail typeDetail = db.TypeDetails.Find(id);
            db.TypeDetails.Remove(typeDetail);
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
