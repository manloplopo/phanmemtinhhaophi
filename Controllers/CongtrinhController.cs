using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phanmemtinhhaophi.Models;

namespace tinhhaophi.Controllers
{
    public class CongtrinhController : Controller
    {
        // GET: ChiTietHoaDon
        phanmemtinhhaophivatlieuxaydungEntities db = new phanmemtinhhaophivatlieuxaydungEntities();

        public ActionResult Index()
        {
            var listtinhhaophi = new DBphanmemtinhhaophivatlieuxaydungConnectionString().Congtrinhs.ToList();
            return View(listtinhhaophi);
        }
        public ActionResult Create()
        {
            var Context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
          
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(Congtrinh model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
                context.Congtrinhs.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
          
        }
        public ActionResult Edit(int Macongtrinh)
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
            var editing = context.Congtrinhs.Find(Macongtrinh);
          

            return View(editing);
        }
        [HttpPost]
        public ActionResult Edit(Congtrinh model)
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
            var oldItem = context.Congtrinhs.Find(model.Macongtrinh);
            oldItem.Tencongtrinh = model.Tencongtrinh;
             oldItem.Tenchudautu = model.Tenchudautu;
            oldItem.Diadiemcongtrinh = model.Diadiemcongtrinh;
            oldItem.Tonggiatri
                = model.Tonggiatri;
            context.SaveChanges();

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int Macongtrinh)
        {
            Congtrinh kq = db.Congtrinh.Find(Macongtrinh);
            return View(kq);
        }
        public ActionResult Delete()
        {
            var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
            
            return View("Delete");
        }
        // xóa và cập nhật lại dữ liệu vào CSDL
        [HttpPost]
        public ActionResult Delete(Congtrinh model)
        {
            try
            {
                var context = new DBphanmemtinhhaophivatlieuxaydungConnectionString();
                
                context.Congtrinhs.Remove(model);
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