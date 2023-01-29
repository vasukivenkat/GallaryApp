using Microsoft.AspNetCore.Mvc;

namespace GallaryApp.Controllers
{
    public class GallaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
    }
}
