using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using QuanLySachT.Models;
using System.Net;

namespace QuanLySachT.Controllers
{
    public class ValidationController : Controller
    {
        private demoQLSTEntities db = new demoQLSTEntities();
        // GET: Validation
        /*public ActionResult Index()
        {
            return View();
        }*/
        //For check both at a time .mailid and empName.
        [HttpGet]
        public JsonResult IsEmpNameandMailExist(int MaPhieu, int MaSach)
        {

            bool isExist = db.CT_PhieuNhap.Where(u => u.MaPhieu.Equals(MaPhieu) && u.MaSach.Equals(MaSach)).FirstOrDefault() != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsMaPhieuandMaSachExist(int MaPhieu, int MaSach)
        {

            bool isExist = db.CT_PhieuXuat.Where(u => u.MaPhieu.Equals(MaPhieu) && u.MaSach.Equals(MaSach)).FirstOrDefault() != null;
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}