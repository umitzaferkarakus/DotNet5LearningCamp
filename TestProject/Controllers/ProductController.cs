using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Controllers
{
    public class ProductController : Controller
    {
        #region VievResult
        //public IActionResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion

        #region ParticialViewResult
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //}
        #endregion

        #region JsonResult
        //public JsonResult GetProducts()
        //{
        //    JsonResult result =Json(new Models.Products
        //    {
        //        Id = 5,
        //        ProductName = "Terlik",
        //        Quantity = 15
        //    });
        //    return result;
        //}
        #endregion

        #region EmptyResult
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        #endregion

        #region ContentResult
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("DENEME");
        //    return result;
        //}
        #endregion

        #region IActionResult
        //public IActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        //...
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("dasdasdas");
        //    }
        //    return View();
        //}
        #endregion

        public IActionResult Index()
        {

            var products = new List<Models.Products>
            {
                new Models.Products{Id=1,ProductName="A Product", Quantity=10},
                new Models.Products{Id=2,ProductName="B Product", Quantity=15},
                new Models.Products{Id=3,ProductName="C Product", Quantity=20}
            };

            #region Model Bazlı Veri Gönderimi
            //return View(products);
            #endregion
            #region Veri Taşıma Kontrolleri
            #region VievBag
            ViewBag.products = products;
            #endregion

            #region VievData

            #endregion

            #region TempData

            #endregion
            #endregion
            return View(products);
        }
    }
}
