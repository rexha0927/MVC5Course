using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;
using System.Data.Entity;

namespace MVC5Course.Controllers
{
    public class TestController : BaseController
    {
        //整個 TestController 改用 Repository 來存取資料
        //FabricsEntities db = new FabricsEntities();

        //如何使用 RepositoryHelper 產生 Repository 物件
        //ProductRepository repo = RepositoryHelper.GetProductRepository();

        // GET: Test
        public ActionResult Index()
        {
            //var data = from p in db.Product
            //           where p.IsDelete == false
            //           select p;

            //如何使用 RepositoryHelper 產生 Repository 物件
            //var repo = new ProductRepository();
            //repo.UnitOfWork = new EFUnitOfWork();
            //var data = repo.All().Where(p => p.IsDelete == false);

            //整個 TestController 改用 Repository 來存取資料
            //var data = repo.All().Where(p => p.IsDelete == false);
            //return View(data.Take(10));

            //透過 Repository 封裝各種商業邏輯/資料存取邏輯
            var data = repo.Get取得所有尚未刪除的商品資料Top10();

            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product data)
        {
            if (ModelState.IsValid)
            {
                //整個 TestController 改用 Repository 來存取資料
                //db.Product.Add(data);
                //db.SaveChanges();

                repo.Add(data);
                repo.UnitOfWork.Commit();

                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Edit(int id)
        {
            //整個 TestController 改用 Repository 來存取資料
            //var item = db.Product.Find(id);

            var item=repo.Find(id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product data)
        {
            if (ModelState.IsValid)
            {
                ////整個 TestController 改用 Repository 來存取資料
                //var item = db.Product.Find(id);
                var item = repo.Find(id);

                item.ProductName = data.ProductName;
                item.Price = data.Price;
                item.Stock = data.Stock;
                item.Active = data.Active;

                TempData["ProductItem"] = item;

                //db.SaveChanges();
                repo.UnitOfWork.Commit();

                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Details(int id)
        {
            //整個 TestController 改用 Repository 來存取資料
            //var item = db.Product.Find(id);

            var item = repo.Find(id);
            if (item == null)
            {
                //return RedirectToAction("Index");
                return HttpNotFound();
            }

            return View(item);
        }

        public ActionResult Delete(int id)
        {
            //整個 TestController 改用 Repository 來存取資料
            //var item = db.Product.Find(id);

            var item = repo.Find(id);

            //db.OrderLine.RemoveRange(item.OrderLine.ToList());
            //db.Product.Remove(item);

            item.IsDelete = true;

            //db.SaveChanges();
            repo.UnitOfWork.Commit();

            return RedirectToAction("Index");
        }
    }
}