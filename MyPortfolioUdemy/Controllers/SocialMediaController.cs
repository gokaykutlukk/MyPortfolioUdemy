using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IActionResult SocialMediaList()
        {
            var values = portfolioContext.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            portfolioContext.SocialMedias.Add(socialMedia);
            portfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = portfolioContext.SocialMedias.Find(id);
            portfolioContext.SocialMedias.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = portfolioContext.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            portfolioContext.SocialMedias.Update(socialMedia);
            portfolioContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
