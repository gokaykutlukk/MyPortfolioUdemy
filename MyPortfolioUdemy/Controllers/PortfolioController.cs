using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IActionResult PortfolioList()
        {
            var values = portfolioContext.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            portfolioContext.Portfolios.Add(portfolio);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioContext.Portfolios.Find(id);
            portfolioContext.Portfolios.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = portfolioContext.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            portfolioContext.Portfolios.Update(portfolio);
            portfolioContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
