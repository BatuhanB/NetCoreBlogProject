using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreLibrary.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            contactManager.AddContact(contact);
            return RedirectToAction("Index","Contact");
        }
    }
}
