using Microsoft.AspNetCore.Mvc;

namespace lez02_aspweb_scambioDati.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
