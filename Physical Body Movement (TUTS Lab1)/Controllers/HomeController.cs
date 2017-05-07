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
        public ChartData GetChartData(string a1, string a2, string time, string x0, string x1)
        {
            if (!double.TryParse(a1, out double a1D) ||
                !double.TryParse(a2, out double a2D) ||
                !double.TryParse(time, out double timeD) ||
                !double.TryParse(x0, out double x0D) ||
                !double.TryParse(x1, out double x1D))
                return new ChartData();

            return Physics.Calculate(a1D, a2D, timeD, x0D, x1D);
            return new ChartData
            {
                X = new List<double> { 1, 2, 3 },
                Y = new List<double> { 3, 2, 1 },
                IsValid = true
            };
        }
    }
}
