using MVC5Course.ViewModels;
using System;
using System.Data.Entity.Validation;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBBatchUpdateVM
    {
        public int ProductId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> Stock { get; set; }
    }
    public class MVController : BaseController
    {
        // GET: MV
        public ActionResult Index()
        {
            var data = repo.Get取得所有尚未刪除的商品資料Top10();

            ViewData.Model = data;

            //ViewData["PageTitle"] = "商品清單";
            ViewBag.PageTitle = "商品清單";

            return View(data);
        }

        [HttpPost]
        [HandleError(ExceptionType = typeof(DbEntityValidationException), View = "Error_DbEntityValidationException")]
        public ActionResult Index(MBBatchUpdateVM[] batch)
        {
            //var success = true;
            //var message = "";

            var data = repo.Get取得所有尚未刪除的商品資料Top10();
            ViewData.Model = data;
            ViewBag.PageTitle = "商品清單";

            if (ModelState.IsValid)
            {
                foreach (var item in batch)
                {
                    var query = repo.Find(item.ProductId);

                    query.Price = item.Price;
                    query.Active = item.Active;
                    query.Stock = item.Stock;
                }
                try
                {
                    repo.UnitOfWork.Commit();
                    //message = "儲存成功";
                }

                catch (DbEntityValidationException ex/*Exception ex*/)
                {
                    //success = false;
                    //message = ex.Message;

                    throw ex;
                }
                return RedirectToAction("Index");
            }
            //return (new
            //{
            //    success,
            //    message,
            //    data = query
            //});

            return View();
        }
    }
}