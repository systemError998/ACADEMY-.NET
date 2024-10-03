using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez02_refactor.classes
{
    internal class DipendenteDAO
    {
        //Gli attributi sono variabili accessibili da tutti i metodi della classe
        private string credenziali = "Server=ACADEMY2024-30\\SQLEXPRESS;Database=lez01_DB_Inizializzazione;User Id=academy;Password=academy2024!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false";
        
        //GetAll
        public List<Dipendente> GetAll()
        { 
            List<Dipendente> elenco = new List<Dipendente>();

            using (SqlConnection connessione = new SqlConnection(credenziali))
            {
                string query = "SELECT dipendenteID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente;";

                SqlCommand cmd = new SqlCommand(query, connessione);

                try
                {
                    connessione.Open();

                    SqlDataReader dati = cmd.ExecuteReader();
                    while (dati.Read())
                    {
                        //Console.WriteLine($"{dati[0]} {dati[1]}");

                        Dipendente dip = new Dipendente()
                        {
                            Id = dati.GetInt32(0),
                            Nome = dati.GetString(1),
                            Cognome = dati.GetString(2),
                            Dipartimento = dati.GetString(3),
                            Identificativo = dati.GetString(4),
                            Salario = dati.GetInt32(5)
                        };

                        elenco.Add(dip);
                    }

                    connessione.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            foreach (Dipendente dip in elenco)
            {
                Console.WriteLine(dip);
            }

            Console.WriteLine("FINE DEL getAll()");

            return elenco;
        }

        //GetById
        public Dipendente? GetById(int varId)
        {
            Dipendente? dipRisultato = null; // potrebbe essere nullable 

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                SqlCommand query = new SqlCommand();
                query.Connection = conn;

                query.CommandText = "SELECT dipendenteID, nome, cognome, dipartimento, identificativo, salario FROM Dipendente WHERE dipendenteID = @varId";
                query.Parameters.AddWithValue("@varId", varId);

                try
                {
                    conn.Open();
                    SqlDataReader sqlDataReader = query.ExecuteReader(); // il reader serve per leggere i dati dal db
                    while (sqlDataReader.Read())
                    {
                        dipRisultato = new Dipendente()
                        {
                            Id = sqlDataReader.GetInt32(0),
                            Identificativo = sqlDataReader.GetString(1),
                            Nome = sqlDataReader.GetString(2),
                            Cognome = sqlDataReader.GetString(3),
                            Dipartimento = sqlDataReader.GetString(4),
                            Salario = sqlDataReader.GetInt32(5)
                        };
                        
                    }
                    conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return dipRisultato;
        }

        //Insert
        public bool InsertDipendente(Dipendente objDip) {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(credenziali))
            {
                //creo un sequel command, ovvero un'istruzione sql
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Dipendente (nome, cognome, dipartimento, salario)\r\nVALUES (@varNome, @varCognome, @varDipartimento, @varSalario)";
                cmd.Parameters.AddWithValue("@varNome", objDip.Nome);
                cmd.Parameters.AddWithValue("@varCognome", objDip.Cognome);
                cmd.Parameters.AddWithValue("@varDipartimento", objDip.Dipartimento);
                cmd.Parameters.AddWithValue("@varSalario", objDip.Salario);

                try
                {
                    conn.Open();
                    int affRows = cmd.ExecuteNonQuery(); //returna le righe coinvolte (affected rows)
                    if (affRows > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return risultato; 
        } 

        //Update
        //Delete
    }
}
