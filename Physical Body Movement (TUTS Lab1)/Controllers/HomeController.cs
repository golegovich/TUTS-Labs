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
        public ChartData GetChartData(string a, string k, string f, int type)
        {
            if (!double.TryParse(a, out double aD) ||
                !double.TryParse(k, out double kD) ||
                !double.TryParse(f, out double fD))
                return new ChartData();

            return Physics.Calculate(aD, kD, fD, type);
        }
    }
}
