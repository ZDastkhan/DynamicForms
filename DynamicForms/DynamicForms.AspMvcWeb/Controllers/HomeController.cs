using DynamicForms.AspMvcWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DynamicForms.Core;
using DynamicForms.Factory;
using Newtonsoft.Json;

namespace DynamicForms.AspMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();                      
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculation()
        {
            ViewBag.Title = "Calculation of Circle Area";
            var calc = new CircleAreaCalculation();
            calc.Name = "Calculation of Circle Area";            
            var json = JsonConvert.SerializeObject(calc);
            return View(json);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
