using lez01_DB_Inizializzazione.classes;
using System.Data.SqlClient; //package sql client , contenente funzionalità e classi

namespace lez01_DB_Inizializzazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integrare librerie
            // https://www.nuget.org/ <- dipendenze per c# , su cui cercare sql client (è come npm per node) 
            //creiamo utenza su ssms
            // restartiamo il demone SQL SERVER EXPRESS (cerca servizi) 

            //CREO LA STRINGA DI CONNESSIONE AL DATABASE
            string credenziali = "Server=ACADEMY2024-30\\SQLEXPRESS;Database=lez01_DB_Inizializzazione;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";

            #region cRud
            //List<Dipendente> elenco = new List<Dipendente>();

            ////Apro un canale di trasmissione tra db (aprire la connessione)
            ////con lo using creo la var di contesto che funziona solo all'interno di questo contesto 
            ////al di fuori il garbage colelctor la eliminerà

            ////Creo un oggetto sql connection chiamato connessione
            //using (SqlConnection connessione = new SqlConnection(credenziali))
            //{
            //    string query = "SELECT dipendenteID,nome,cognome,dipartimento,identificativo,salario FROM Dipendente";

            //    //Inviare comando SQL
            //    //Creo un protocollo di invio dati sql , sul canale di comunicazione CONNESSIONE con la query che ho stabilito prima
            //    SqlCommand comandoSQL = new SqlCommand(query, connessione);

            //    //PROVO A FARE LA CONNESSIONE.
            //    //E' importante inserire la connessione all'interno del trycatch perchè se la conn non va a buon fine riceviamo un errore
            //    try
            //    {
            //        //con open verifico che le credenziali (ovvero la stringa di connessione) siano corrette 
            //        connessione.Open();

            //        // comandoSQL.ExecuteNonQuery(); //restituisce le righe coinvolte nell'operazione (dml)
            //        SqlDataReader dati = comandoSQL.ExecuteReader(); // is used to read data from the SQL Server database
            //        while (dati.Read())
            //        {
            //            // Console.WriteLine($"{ dati[0]}  { dati[1]}");
            //            Dipendente dip = new Dipendente()
            //            {
            //                Id = dati.GetInt32(0),
            //                Identificativo = dati.GetString(1),
            //                Nome = dati.GetString(2),
            //                Cognome = dati.GetString(3),
            //                Dipartimento = dati.GetString(4),
            //                Salario = dati.GetInt32(5)
            //            };

            //            elenco.Add(dip);
            //        }

            //        connessione.Close();
            //    };

            //foreach (Dipendente dip in elenco)
            //{
            //    dip.ToString();
            //}
            #endregion

            #region Crud

            //Dipendente gio = new Dipendente()
            //{
            //    Nome = "Giovanni",
            //    Cognome = "Pace",
            //    Dipartimento = "IT",
            //    Salario = 100000
            //};

            //using (SqlConnection conn = new SqlConnection(credenziali))
            //{
            //    //creo un sequel command, ovvero un'istruzione sql
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandText = "INSERT INTO Dipendente (nome, cognome, dipartimento, salario)\r\nVALUES (@varNome, @varCognome, @varDipartimento, @varSalario)";
            //    cmd.Parameters.AddWithValue("@varNome", gio.Nome);
            //    cmd.Parameters.AddWithValue("@varCognome", gio.Cognome);
            //    cmd.Parameters.AddWithValue("@varDipartimento", gio.Dipartimento);
            //    cmd.Parameters.AddWithValue("@varSalario", gio.Salario);

            //    try
            //    {
            //        conn.Open();
            //        int affRows = cmd.ExecuteNonQuery(); //returna le righe coinvolte (affected rows)
            //            if (affRows > 0)
            //                Console.WriteLine("okok");
            //            else Console.WriteLine("errore");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            #endregion Crud

            #region cruD
            //int idDaEliminare = 5;

            //using (SqlConnection conn = new SqlConnection(credenziali))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;

            //    cmd.CommandText = "DELETE FROM Dipendete WHERE dipendenteID = @varId";
            //    cmd.Parameters.AddWithValue("@varId", idDaEliminare);

            //    try
            //    {
            //        conn.Open();

            //        int affRows = cmd.ExecuteNonQuery();
            //            if (affRows > 0)
            //                Console.WriteLine("okok");
            //            else Console.WriteLine("errore");

            //        conn.Close();
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
            #endregion

            #region crUd

            Dipendente gio = new Dipendente()
            {
                Id = 10,
                Nome = "Giovanna",
                Cognome = "Pace",
                Dipartimento = "Managment",
                Salario = 120000
            };

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE Dipendente SET nome = @varNome, cognome = @varCognome, dipartimento = @varDipartimento, salario = @varSalario WHERE dipendenteID = @varId";
                cmd.Parameters.AddWithValue("@varNome", gio.Nome);
                cmd.Parameters.AddWithValue("@varCognome", gio.Cognome);
                cmd.Parameters.AddWithValue("@varDipartimento", gio.Dipartimento);
                cmd.Parameters.AddWithValue("@varSalario", gio.Salario);
                cmd.Parameters.AddWithValue("@varId", gio.Id);


                #endregion
            }

    }

}
