using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLySachT.Models;

namespace QuanLySachT.Controllers
{
    public class CT_PhieuYeuCauMuaController : Controller
    {
        private demoQLSTEntities db = new demoQLSTEntities();

        // GET: CT_PhieuYeuCauMua
        public ActionResult Index()
        {
            var cT_PhieuYeuCauMua = db.CT_PhieuYeuCauMua.Include(c => c.PhieuYeuCauMua).Include(c => c.Sach);
            return View(cT_PhieuYeuCauMua.ToList());
        }

        // GET: CT_PhieuYeuCauMua/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_PhieuYeuCauMua cT_PhieuYeuCauMua = db.CT_PhieuYeuCauMua.Find(id);
            if (cT_PhieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            return View(cT_PhieuYeuCauMua);
        }

        // GET: CT_PhieuYeuCauMua/Create
        public ActionResult Create()
        {
            ViewBag.MaPhieu = new SelectList(db.PhieuYeuCauMuas, "MaPhieu", "MaPhieu");
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach");
            return View();
        }

        // POST: CT_PhieuYeuCauMua/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SoLuong,MaPhieu,MaSach")] CT_PhieuYeuCauMua cT_PhieuYeuCauMua)
        {
            if (ModelState.IsValid)
            {
                db.CT_PhieuYeuCauMua.Add(cT_PhieuYeuCauMua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaPhieu = new SelectList(db.PhieuYeuCauMuas, "MaPhieu", "MaPhieu", cT_PhieuYeuCauMua.MaPhieu);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", cT_PhieuYeuCauMua.MaSach);
            return View(cT_PhieuYeuCauMua);
        }

        // GET: CT_PhieuYeuCauMua/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_PhieuYeuCauMua cT_PhieuYeuCauMua = db.CT_PhieuYeuCauMua.Find(id);
            if (cT_PhieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaPhieu = new SelectList(db.PhieuYeuCauMuas, "MaPhieu", "MaPhieu", cT_PhieuYeuCauMua.MaPhieu);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", cT_PhieuYeuCauMua.MaSach);
            return View(cT_PhieuYeuCauMua);
        }

        // POST: CT_PhieuYeuCauMua/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SoLuong,MaPhieu,MaSach")] CT_PhieuYeuCauMua cT_PhieuYeuCauMua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cT_PhieuYeuCauMua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaPhieu = new SelectList(db.PhieuYeuCauMuas, "MaPhieu", "MaPhieu", cT_PhieuYeuCauMua.MaPhieu);
            ViewBag.MaSach = new SelectList(db.Saches, "MaSach", "TenSach", cT_PhieuYeuCauMua.MaSach);
            return View(cT_PhieuYeuCauMua);
        }

        // GET: CT_PhieuYeuCauMua/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_PhieuYeuCauMua cT_PhieuYeuCauMua = db.CT_PhieuYeuCauMua.Find(id);
            if (cT_PhieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            return View(cT_PhieuYeuCauMua);
        }

        // POST: CT_PhieuYeuCauMua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CT_PhieuYeuCauMua cT_PhieuYeuCauMua = db.CT_PhieuYeuCauMua.Find(id);
            db.CT_PhieuYeuCauMua.Remove(cT_PhieuYeuCauMua);
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
