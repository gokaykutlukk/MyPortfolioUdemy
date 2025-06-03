using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyPortfolioUdemy.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Örnek grafik verisi (istatistik, kategori vs.)
            var chartData = new List<(string Label, int Value)>
            {
                ("Frontend", 40),
                ("Backend", 30),
                ("Database", 20),
                ("DevOps", 10)
            };

            ViewBag.ChartData = chartData;
            return View();
        }
    }
}
