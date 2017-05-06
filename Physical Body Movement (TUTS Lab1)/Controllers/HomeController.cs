using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Physical_Body_Movement__TUTS_Lab1_.Models;

namespace Physical_Body_Movement__TUTS_Lab1_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public ChartData GetChartData(string a1, string a2, string distance, string time)
        {
            double a1D;
            double a2D;
            double distanceD;
            double timeD;
            
            if (!double.TryParse(a1, out a1D) ||
                !double.TryParse(a2, out a2D) ||
                !double.TryParse(distance, out distanceD) ||
                !double.TryParse(time, out timeD))
                return new ChartData();
            
            return new ChartData
            {
                X = new List<double> { 1, 2, 3 },
                Y = new List<double> { 3, 2, 1 },
                IsValid = true
            };
        }
    }
}
