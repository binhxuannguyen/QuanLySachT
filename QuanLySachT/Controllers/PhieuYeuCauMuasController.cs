﻿using System;
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
    public class PhieuYeuCauMuasController : Controller
    {
        private demoQLSTEntities db = new demoQLSTEntities();

        // GET: PhieuYeuCauMuas
        public ActionResult Index()
        {
            var phieuYeuCauMuas = db.PhieuYeuCauMuas.Include(p => p.DaiLy);
            return View(phieuYeuCauMuas.ToList());
        }

        // GET: PhieuYeuCauMuas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuYeuCauMua phieuYeuCauMua = db.PhieuYeuCauMuas.Find(id);
            if (phieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            return View(phieuYeuCauMua);
        }

        // GET: PhieuYeuCauMuas/Create
        public ActionResult Create()
        {
            ViewBag.MaDaiLy = new SelectList(db.DaiLies, "MaDaiLy", "TenDaiLy");
            return View();
        }

        // POST: PhieuYeuCauMuas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhieu,NgayGio,MaDaiLy,TinhTrang")] PhieuYeuCauMua phieuYeuCauMua)
        {
            if (ModelState.IsValid)
            {
                db.PhieuYeuCauMuas.Add(phieuYeuCauMua);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDaiLy = new SelectList(db.DaiLies, "MaDaiLy", "TenDaiLy", phieuYeuCauMua.MaDaiLy);
            return View(phieuYeuCauMua);
        }

        // GET: PhieuYeuCauMuas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuYeuCauMua phieuYeuCauMua = db.PhieuYeuCauMuas.Find(id);
            if (phieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDaiLy = new SelectList(db.DaiLies, "MaDaiLy", "TenDaiLy", phieuYeuCauMua.MaDaiLy);
            return View(phieuYeuCauMua);
        }

        // POST: PhieuYeuCauMuas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhieu,NgayGio,MaDaiLy,TinhTrang")] PhieuYeuCauMua phieuYeuCauMua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuYeuCauMua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDaiLy = new SelectList(db.DaiLies, "MaDaiLy", "TenDaiLy", phieuYeuCauMua.MaDaiLy);
            return View(phieuYeuCauMua);
        }

        // GET: PhieuYeuCauMuas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuYeuCauMua phieuYeuCauMua = db.PhieuYeuCauMuas.Find(id);
            if (phieuYeuCauMua == null)
            {
                return HttpNotFound();
            }
            return View(phieuYeuCauMua);
        }

        // POST: PhieuYeuCauMuas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhieuYeuCauMua phieuYeuCauMua = db.PhieuYeuCauMuas.Find(id);
            db.PhieuYeuCauMuas.Remove(phieuYeuCauMua);
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
