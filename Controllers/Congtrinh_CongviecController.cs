using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phanmemtinhhaophi.Models;

namespace tinhhaophi.Controllers
{
    public class Congtrinh_CongviecController : Controller
    {
        // GET: ChiTietHoaDon
        phanmemtinhhaophivatlieuxaydungEntities db = new phanmemtinhhaophivatlieuxaydungEntities();

        public ActionResult Index()
        {
            var listCongviec_Congtrinh = new DBphanmemtinhhaophivatlieuxaydungConnectionString().Congtrinh_Congviec.ToList();
            return View(listCongviec_Congtrinh);

        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Congtrinh_Congviec Congtrinh_Congviec)
        {
            db.Congtrinh_Congviec.Add(Congtrinh_Congviec);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            Congtrinh_Congviec kq = db.Congtrinh_Congviec.Find(id);

            return View(kq);
        }
        [HttpPost]
        public ActionResult Edit(Congtrinh_Congviec Congtrinh_Congviec)
        {
            Congtrinh_Congviec kq = db.Congtrinh_Congviec.Find(Congtrinh_Congviec.Macongtrinh);
            kq.Macongtrinh = Congtrinh_Congviec.Macongtrinh;
            kq.Macongviec = Congtrinh_Congviec.Macongviec;
            kq.Soluong = Congtrinh_Congviec.Soluong;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            Congtrinh_Congviec kq = db.Congtrinh_Congviec.Find(id);
            return View(kq);
        }
        public ActionResult Delete()
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

            return View("Delete");
        }
        // xóa và cập nhật lại dữ liệu vào CSDL
        [HttpPost]
        public ActionResult Delete(Congtrinh_Congviec model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();

                context.Congtrinh_Congviec.Remove(model);
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