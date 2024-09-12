namespace lez02_04_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gio = { "Giovanni", "Pace", "1243213" };
            string[] val = { "Valeria", "Verdi Verdoni", "523223" };
            string[] mar = { "Mario", "Rossi", "4327642" };

            List<string[]> elenco = new List<string[]>();
            elenco.Add(gio);
            elenco.Add(val);
            elenco.Add(mar);

            //Stampo tutte le matricole
            //for (int i = 0; i < elenco.Count; i++) {
            //    Console.WriteLine(elenco[i][2]);
            //}

            //Stampo tutti i dati delle persone nell'array elenco
            //for (int i = 0; i < elenco.Count; i++) {
            //    Console.WriteLine($"Nome: {elenco[i][0]}, Cognome: {elenco[i][1]}, Matricola: {elenco[i][2]}");
            //}

            //COUNT PER ARRAY DINAMICI
            //LENGTH PER ARRAY STATICI

            //Nested Cicle
            for (int i = 0; i < elenco.Count; i++)
            {
                for (int j = 0; j < elenco[i].Length; j++) {
                    Console.WriteLine(elenco[i][j]);
                }
            }

        }
    }
}
