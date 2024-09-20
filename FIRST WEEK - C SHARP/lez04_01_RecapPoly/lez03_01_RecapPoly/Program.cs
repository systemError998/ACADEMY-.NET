using lez03_01_RecapPoly.classes;

namespace lez03_01_RecapPoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creare un sistema di gestione scolastica dove le informazioni di cui abbiamo bisogno sono:
            //-Studente
            //-Docente

            Studente stu = new Studente("Valeria", "Vedi", "VLRVRD98", "AB1234", "Informatica");
            Persona stu2 = new Studente("Giovanni", "Pace", "GVNPCE", "AB1235", "Psicologia");

            //Non posso accedere ai metodi di studente perchè lo sto dichiarando come persona
            Persona stu3 = new Studente("Mario", "Rossi", "MRORSS", "AB1236", "Giurisprudenza");
            //Con il casting sto assicurando che stu3 è effettivamente uno studente
            Studente stu3Castato = (Studente)stu3;
            //In questo modo, essendo una persona, posso inserirlo in una List<> di persone
            //E allo stesso tempo posso essere uno studente e quindi accedere ai metodi di studente 

            //BINDING DINAMICO
            //Non so quante celle di memoria occuperò finchè non eseguirò il codice
            //perchè finchè non eseguo il codice non so che TIPO è
            Persona doc = new Docente("Emanuele", "Umberto", "MNLBRT", "Informatica", true);

            //con var posso inserire nella variabile QUALUNQUE cosa io voglia
            var pippo = new Studente("Mario", "Gialli", "MRORSS", "AB1236", "Giurisprudenza");

            //BINDING STATICO
            Docente doc2 = new Docente("Laura", "Rossi", "LRARSS", "Informatica", false);

            //List<Persona> elencoPersone = new List<Persona>();
            //elencoPersone.Add(stu2);
            //elencoPersone.Add(stu3);
            //elencoPersone.Add(doc);

            ////Voglio stampare l
            //foreach (Persona per in elencoPersone) {
            //    // Console.WriteLine(per); // = per.ToString()
            //    if (per.GetType() == typeof(Studente))
            //    {
            //        //ESEGUO IL CAST SOLO SE SEI UNO STUDENTE, quindi da persona-studente ti trasformo in studente
            //        Studente student = (Studente)per;
            //        student.StampaCartaInt();
            //    }
            //    else {
            //        Console.WriteLine($"Docente: {per}");
            //    }
            //}

            //--------------------CLASSES UNVIVERSITA'-------------------------
            Universita iemacademy = new Universita();
            iemacademy.InserisciStudente(stu); //Posso aggiungere solo stu perchè è di tipo Studente, non stu2 perchè è di tipo Persona
            iemacademy.InserisciDocente(doc2); //ibidem

            iemacademy.StampaTutti();
            iemacademy.StampaStudenti();
            iemacademy.StampaDocenti();

        }
    }
}
