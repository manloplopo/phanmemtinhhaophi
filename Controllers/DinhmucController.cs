using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phanmemtinhhaophi.Models;

namespace tinhhaophi.Controllers
{
    public class DinhmucController : Controller
    {
        // GET: ChiTietHoaDon
        phanmemtinhhaophivatlieuxaydungEntities db = new phanmemtinhhaophivatlieuxaydungEntities();

        public ActionResult Index()
        {
            var listDinhmuc = new DBphanmemtinhhaophivatlieuxaydungConnectionString().Dinhmucs.ToList();
            return View(listDinhmuc);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Dinhmuc Dinhmuc)
        {
            db.Dinhmuc.Add(Dinhmuc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            Dinhmuc kq = db.Dinhmuc.Find(id);

            return View(kq);
        }
        [HttpPost]
        public ActionResult Edit(Dinhmuc Dinhmuc)
        {
            Dinhmuc kq = db.Dinhmuc.Find(Dinhmuc.Macongviec);
            kq.Macongviec = Dinhmuc.Macongviec;
            kq.Mavattu = Dinhmuc.Mavattu;
            kq.Soluong = Dinhmuc.Soluong;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Dinhmuc kq = db.Dinhmuc.Find(id);
            return View(kq);
        }
        public ActionResult Delete()
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

            return View("Delete");
        }
        // xóa và cập nhật lại dữ liệu vào CSDL
        [HttpPost]
        public ActionResult Delete(Dinhmuc model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

                context.Dinhmucs.Remove(model);
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