using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IActionResult AboutList()
        {
            var values = portfolioContext.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            portfolioContext.Abouts.Add(about);
            portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = portfolioContext.Abouts.Find(id);
            portfolioContext.Abouts.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = portfolioContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            portfolioContext.Abouts.Update(about);
            portfolioContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
