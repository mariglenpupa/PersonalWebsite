using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class URLShortnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
