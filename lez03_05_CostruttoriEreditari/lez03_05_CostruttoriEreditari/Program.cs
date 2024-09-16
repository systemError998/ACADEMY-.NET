namespace lez03_05_CostruttoriEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente gio = new Studente("Giovanni", "Pace", "AB1234");
            gio.StampaDettaglio();


            Docente doc = new Docente();
            doc.Nome = "Valeria";
            doc.Cognome = "Rossi";
            doc.Dipartimento = "ING";

            doc.StampaDettaglio();
        }
    }
}
