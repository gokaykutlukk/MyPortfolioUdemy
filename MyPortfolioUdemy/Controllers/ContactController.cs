using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IActionResult ContactList()
        {
            var values = portfolioContext.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            portfolioContext.Contacts.Add(contact);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = portfolioContext.Contacts.Find(id);
            portfolioContext.Contacts.Remove(value);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = portfolioContext.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            portfolioContext.Contacts.Update(contact);
            portfolioContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
