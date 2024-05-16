using LugXGaming.Models;
using LugXGaming.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LugXGaming.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Gamecu gamecu=new Gamecu("Welcome the best Game Site","These are only simple games",25,50,"banner-image.jpg");
            HomeVM vm = new HomeVM
            {
                Gamecu = gamecu
            };
            return View(vm);

        }
    }
}
