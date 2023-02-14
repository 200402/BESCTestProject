using Car.Models;
using Car.Models.FillingDB;
using DataBase.Interfaces;
using Car.Models.FillingDB;
using Car.Models.FillingDB.JSONtypes;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Car.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBrand brand;

        public HomeController(ILogger<HomeController> logger, IBrand brand)
        {
            this._logger = logger;
            this.brand = brand;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FillDB()
        {
            Fill.Filling(brand);
            return RedirectPermanent("~/Home/Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}