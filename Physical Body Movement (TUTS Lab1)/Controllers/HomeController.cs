using Microsoft.AspNetCore.Mvc;
using Physical_Body_Movement__TUTS_Lab1_.Models;
using System.Globalization;

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
        public ChartData GetChartData(string a, string k, int type, int funcNumber)
        {
            if (!double.TryParse(a, NumberStyles.Any, CultureInfo.InvariantCulture, out double aD) ||
                !double.TryParse(k, NumberStyles.Any, CultureInfo.InvariantCulture, out double kD))
                return new ChartData();

            return Physics.Calculate(aD, kD, type, funcNumber);
        }
    }
}
