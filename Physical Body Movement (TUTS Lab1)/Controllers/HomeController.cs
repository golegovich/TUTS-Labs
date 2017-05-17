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
        public ChartData GetChartData(string a1, string a2, string time, string x0, string x1)
        {
            if (!double.TryParse(a1, NumberStyles.Any,  CultureInfo.InvariantCulture, out double a1D) ||
                !double.TryParse(a2, NumberStyles.Any,  CultureInfo.InvariantCulture, out double a2D) ||
                !double.TryParse(time, NumberStyles.Any,  CultureInfo.InvariantCulture, out double timeD) ||
                !double.TryParse(x0, NumberStyles.Any,  CultureInfo.InvariantCulture, out double x0D) ||
                !double.TryParse(x1, NumberStyles.Any,  CultureInfo.InvariantCulture, out double x1D))
                return new ChartData();

            return Physics.Calculate(a1D, a2D, timeD, x0D, x1D);
        }
    }
}
