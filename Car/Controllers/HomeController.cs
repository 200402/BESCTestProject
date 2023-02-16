using Car.Models;
using Car.Models.FillingDB;
using Car.Models.FillingDB.JSONtypes;
using DataBase.Interfaces;
using DataBase.Tables;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
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
            var qwe = model.AllModels; //Понятия не имею почему, но без этого brand.AllBrands понятия не имеет какие модели у брендов 
        }

        public IActionResult AllModel()
        {
            ViewBag.brands = brand.AllBrands;
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

        [HttpGet]
        public IEnumerable<Brand> GetDetails()
        {
            return brand.AllBrands;
        }

        [HttpPost]
        public void CreateModel(Model newModel)
        {
            if(newModel.Id == Guid.Empty)
            {
                model.InsertModel(newModel);
                model.Save();
            }
            else
            {
                model.UpdateModel(newModel);
                model.Save();
            }
        }

        [HttpPost]
        public void DeleteModel(Model delModel)
        {
            model.DeleteModel(delModel);
            model.Save();
        }

        [HttpPost]
        public void CreateBrand(Brand newBrand)
        {
            if(newBrand.Id == Guid.Empty)
            {
                brand.InsertBrand(newBrand);
                brand.Save();
            }
            else
            {
                brand.UpdateBrand(newBrand);
                brand.Save();
            }
        }

        [HttpPost]
        public void DeleteBrand(Brand delBrand)
        {
            brand.DeleteBrand(delBrand);
            brand.Save();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}