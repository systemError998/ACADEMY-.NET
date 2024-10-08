using Microsoft.AspNetCore.Mvc;

namespace lez01_aspweb_intro.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
