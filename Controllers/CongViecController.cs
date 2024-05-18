using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phanmemtinhhaophi.Models;

namespace tinhhaophi.Controllers
{
    public class CongViecController : Controller
    {
        // GET: ChiTietHoaDon
        phanmemtinhhaophivatlieuxaydungEntities db = new phanmemtinhhaophivatlieuxaydungEntities();

        public ActionResult Index()
        {
            var listCongviec = new DBphanmemtinhhaophivatlieuxaydungConnectionString().Congviecs.ToList();
            return View(listCongviec);
        }
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Congviec Congviec)
        {
            db.Congviec.Add(Congviec);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            Congviec kq = db.Congviec.Find(id);
           
            return View(kq);
        }
        [HttpPost]
        public ActionResult Edit(Congviec Congviec)
        {
            Congviec kq = db.Congviec.Find(Congviec.Macongviec);
            kq.Macongviec = Congviec.Macongviec;
            kq.Tencongviec = Congviec.Tencongviec;
            kq.Ghichu = Congviec.Ghichu;
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Congviec kq = db.Congviec.Find(id);
            return View(kq);
        }
        public ActionResult Delete()
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

            return View("Delete");
        }
        // xóa và cập nhật lại dữ liệu vào CSDL
        [HttpPost]
        public ActionResult Delete(Congviec model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

                context.Congviecs.Remove(model);
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