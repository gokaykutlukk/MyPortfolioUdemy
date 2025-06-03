using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IActionResult TestimonialList()
        {
            var values = portfolioContext.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            portfolioContext.Testimonials.Add(testimonial);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = portfolioContext.Testimonials.Find(id);
            portfolioContext.Testimonials.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = portfolioContext.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            portfolioContext.Testimonials.Update(testimonial);
            portfolioContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
