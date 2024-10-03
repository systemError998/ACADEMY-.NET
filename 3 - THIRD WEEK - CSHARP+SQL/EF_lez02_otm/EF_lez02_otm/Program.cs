using EF_lez02_otm.Models;

namespace EF_lez02_otm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona osv = new Persona()
            {
                Nome = "Osvaldo",
                Cognome = "Bevilacqua",
                Email = "osv@bevi.com"
            };

            Cartum cartUno = new Cartum()
            {
                Codice = "CC0099",
                Negozio = "Conad",
                PersonaRifNavigation = osv
            };

            using (var ctx = new Lez06OtmCarteContext())
            {
                try
                {
                    ctx.Personas.Add(osv);
                    ctx.Carta.Add(cartUno);
                    ctx.SaveChanges();

                    Console.WriteLine("ok");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //-------------------------------------------------------------------

            using (var ctx = new Lez06OtmCarteContext()) 
            {
                var elencoCarte = ctx.Carta.ToList();

                foreach (var cart in elencoCarte)
                {
                    cart.PersonaRifNavigation = ctx.Personas.Single(p => p.PersonaId == cart.PersonaRif);
                    Console.WriteLine(cart);
                }
            }

            //-------------------------------------------------------------------

            using (var ctx = new Lez06OtmCarteContext())
            { 
            
            }




        }
    }
}
