using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using System.Linq;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.TestimonialCount = context.Testimonials.Count();
            ViewBag.ExperienceCount = context.Experiences.Count();

            ViewBag.MessageCount = context.Messages.Count();
            ViewBag.UnreadMessageCount = context.Messages.Where(x => !x.IsRead).Count();
            ViewBag.ReadMessageCount = context.Messages.Where(x => x.IsRead).Count();

            return View();  // Index.cshtml döner
        }
    }
}
