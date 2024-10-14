using lez02_aspweb_scambioDati.Models;
using Microsoft.AspNetCore.Mvc;

namespace lez02_aspweb_scambioDati.Controllers
{
    public class HelloController : Controller
    {
        public string SalutaGenerico() {
            return "Ciao anna";
        }

        public IActionResult Index()
        {
            ViewBag.Titolo = "Sono il titolo di index"; 
            ViewBag.Sottotitolo = "Sono il sottotitolo"; // mai usare una viewbag per qualcosa di più complesso di stringhe e numeri
            ViewBag.Numero = 5;
            ViewBag.Saluta = SalutaGenerico();

            Persona val = new Persona()
            {
                Nominativo = "Valeria Verdi",
                CodFis = "VLRVRD"
            };


            return View();
        }

        [HttpGet]

        public IActionResult Lista() { 
            
            return View();
        }
    }
}
