using lez01_cookie_sessioni.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace lez01_cookie_sessioni.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Emissione() {
            HttpContext.Response.Cookies.Append("lingua", "ITA");
            HttpContext.Response.Cookies.Append("dimensione font", "32px");

            Persona persona = new Persona()
            {
                Nome = "Giovanni",
                Cognome = "Pace"
            };

            HttpContext.Response.Cookies.Append("utente", JsonConvert.SerializeObject(persona));


            return View();
        }

        public IActionResult Lettura() {

            ViewBag.lingua = HttpContext.Request.Cookies["lingua"];
            return View();

        }
    }
}
