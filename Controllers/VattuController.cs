using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phanmemtinhhaophi.Models;

namespace tinhhaophi.Controllers
{
    public class VattuController : Controller
    {
        // GET: ChiTietHoaDon
        phanmemtinhhaophivatlieuxaydungEntities db = new phanmemtinhhaophivatlieuxaydungEntities();

        public ActionResult Index()
        {
             var listVattu = new DBphanmemtinhhaophivatlieuxaydungConnectionString().Vattus.ToList();
            return View(listVattu);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create( Vattu Vattu)
        {
            db.Vattu.Add(Vattu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            Vattu kq = db.Vattu .Find(id);

            return View(kq);
        }
        [HttpPost]
        public ActionResult Edit(Vattu Vattu)
        {
            Vattu kq = db.Vattu.Find(Vattu.Mavattu);
            kq.Mavattu = Vattu.Mavattu;
            kq.Tenvattu = Vattu.Tenvattu;
            kq.Quycach = Vattu.Quycach;
            kq.
                Donvitinh = Vattu.Donvitinh;
            kq.Dongia = Vattu.Dongia;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Vattu kq = db.Vattu.Find(id);
            return View(kq);
        }
        public ActionResult Delete()
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

            return View("Delete");
        }
        // xóa và cập nhật lại dữ liệu vào CSDL
        [HttpPost]
        public ActionResult Delete(Vattu model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

                context.Vattus.Remove(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}