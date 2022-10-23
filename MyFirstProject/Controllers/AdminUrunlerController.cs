using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using MyFirstProject.Models.Entities;


namespace MyFirstProject.Controllers
{
    public class AdminUrunlerController : Controller
    {
        DbShopperProjectEntities db = new DbShopperProjectEntities();
        public ActionResult Index()
        {
            var values = db.TblProducts.ToList();
            return View(values);
        }
        public ActionResult DeleteProduct(int id)
        {
            var values = db.TblProducts.Find(id);
            db.TblProducts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(TblProducts p)
        {
            db.TblProducts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var values = db.TblProducts.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateProduct(TblProducts p)
        {
            var values = db.TblProducts.Find(p.ProductID);
            values.ProductName = p.ProductName;
            values.Description = p.Description;
            values.Price = p.Price;
            values.Stock = p.Stock;
            values.CategoryID = p.CategoryID;
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}