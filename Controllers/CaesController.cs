using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DogAndPeoples.Models;

namespace DogAndPeoples.Controllers
{
    public class CaesController : Controller
    {
        private DogAndPeoplesEntities db = new DogAndPeoplesEntities();

        // GET: Caes
        public ActionResult Index()
        {
            return View(db.Caes.ToList());
        }

        // GET: Caes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = db.Caes.Find(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // GET: Caes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Caes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Raca")] Caes caes)
        {
            if (ModelState.IsValid)
            {
                db.Caes.Add(caes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(caes);
        }

        // GET: Caes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = db.Caes.Find(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // POST: Caes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Raca")] Caes caes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(caes);
        }

        // GET: Caes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes caes = db.Caes.Find(id);
            if (caes == null)
            {
                return HttpNotFound();
            }
            return View(caes);
        }

        // POST: Caes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Caes caes = db.Caes.Find(id);
            db.Caes.Remove(caes);
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
