using Car.Models;
using Car.Models.FillingDB;
using DataBase.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Car.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBrand brand;
        private readonly IModel model;

        public HomeController(ILogger<HomeController> logger, IBrand brand, IModel model)
        {
            this._logger = logger;
            this.brand = brand;
            this.model = model;
        }

        public IActionResult AllModel()
        {
            ViewBag.cars = model.AllModels;
            return View();
        }

        public IActionResult AllBrand()
        {
            ViewBag.brands = brand.AllBrands;
            return View();
        }

        public IActionResult AllBrandAndModel()
        {
            var qwe = model.AllModels; //Понятия не имею почему, но без этого brand.AllBrands понятия не имеет какие модели у брендов 

            ViewBag.brands = brand.AllBrands;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FillDB()
        {
            Fill.Filling(brand);
            ViewBag.brands = brand.AllBrands;
            return RedirectPermanent("~/Home/AllModel");
        }

        protected void CheckedChanged(object sender, EventArgs e)
        {
            Privacy();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}