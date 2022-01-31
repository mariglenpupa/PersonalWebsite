using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
