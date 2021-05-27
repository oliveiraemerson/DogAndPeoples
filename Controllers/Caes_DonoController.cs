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
    public class Caes_DonoController : Controller
    {
        private DogAndPeoplesEntities db = new DogAndPeoplesEntities();

        // GET: Caes_Dono
        public ActionResult Index()
        {
            var caes_Dono = db.Caes_Dono.Include(c => c.Caes).Include(c => c.Donos);
            return View(caes_Dono.ToList());
        }

        // GET: Caes_Dono/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes_Dono caes_Dono = db.Caes_Dono.Find(id);
            if (caes_Dono == null)
            {
                return HttpNotFound();
            }
            return View(caes_Dono);
        }

        // GET: Caes_Dono/Create
        public ActionResult Create()
        {
            ViewBag.Id_cao = new SelectList(db.Caes, "Id", "Nome");
            ViewBag.Id_dono = new SelectList(db.Donos, "Id", "Nome");
            return View();
        }

        // POST: Caes_Dono/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id_dono,Id_cao")] Caes_Dono caes_Dono)
        {
            if (ModelState.IsValid)
            {
                db.Caes_Dono.Add(caes_Dono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_cao = new SelectList(db.Caes, "Id", "Nome", caes_Dono.Id_cao);
            ViewBag.Id_dono = new SelectList(db.Donos, "Id", "Nome", caes_Dono.Id_dono);
            return View(caes_Dono);
        }

        // GET: Caes_Dono/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes_Dono caes_Dono = db.Caes_Dono.Find(id);
            if (caes_Dono == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_cao = new SelectList(db.Caes, "Id", "Nome", caes_Dono.Id_cao);
            ViewBag.Id_dono = new SelectList(db.Donos, "Id", "Nome", caes_Dono.Id_dono);
            return View(caes_Dono);
        }

        // POST: Caes_Dono/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id_dono,Id_cao")] Caes_Dono caes_Dono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caes_Dono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_cao = new SelectList(db.Caes, "Id", "Nome", caes_Dono.Id_cao);
            ViewBag.Id_dono = new SelectList(db.Donos, "Id", "Nome", caes_Dono.Id_dono);
            return View(caes_Dono);
        }

        // GET: Caes_Dono/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caes_Dono caes_Dono = db.Caes_Dono.Find(id);
            if (caes_Dono == null)
            {
                return HttpNotFound();
            }
            return View(caes_Dono);
        }

        // POST: Caes_Dono/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Caes_Dono caes_Dono = db.Caes_Dono.Find(id);
            db.Caes_Dono.Remove(caes_Dono);
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
