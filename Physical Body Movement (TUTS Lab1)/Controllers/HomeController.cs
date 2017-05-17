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
        public ChartData GetChartData(string tu, string tg, string t, string thetaCoefficient, string n, int type)
        {
            if (!double.TryParse(tu, NumberStyles.Any, CultureInfo.InvariantCulture, out double tuD) ||
                !double.TryParse(tg, NumberStyles.Any, CultureInfo.InvariantCulture, out double tgD) ||
                !double.TryParse(t, NumberStyles.Any, CultureInfo.InvariantCulture, out double tD) ||
                !double.TryParse(thetaCoefficient, NumberStyles.Any, CultureInfo.InvariantCulture, out double thetaCoefficientD) ||
                !double.TryParse(n, NumberStyles.Any, CultureInfo.InvariantCulture, out double nD))
                return new ChartData();

            return Physics.Calculate(tuD, tgD, tD, thetaCoefficientD, nD, type);
        }
    }
}
