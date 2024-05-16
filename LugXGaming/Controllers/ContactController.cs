using LugXGaming.Models;
using LugXGaming.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LugXGaming.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contact contact = new Contact("Contact us", "Enter the contact information below", "Discover the latest and greatest in the gaming world!", "Azerbaijan,Baku,Nizami str,27", "lugxgame@example.com");

            ContactVM ct = new ContactVM
            {
               Contact = contact
           };
            return View();
        }
    }
}
