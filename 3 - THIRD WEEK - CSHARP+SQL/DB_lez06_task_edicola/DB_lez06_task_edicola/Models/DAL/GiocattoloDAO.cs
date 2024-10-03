using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal class GiocattoloDAO : IDaoLettura<Giocattolo>, IDaoScrittura<Giocattolo>
    {
        private static GiocattoloDAO? instance;
        public static GiocattoloDAO GetInstance() {
            if (instance == null) 
                instance = new GiocattoloDAO();
            return instance;
        }
        private GiocattoloDAO() { }

        public List<Giocattolo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Giocattolo> GetAllGiocattoli()
        {
            List<Giocattolo> giocattoli = new List<Giocattolo>();

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT libroId, codice, nome, materiale, eta_minima, prezzo FROM Giocattolo";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader(); //sqldata reader è una funzione in grado di ospitare una tabella sql
                    while (reader.Read())
                    {
                        Giocattolo joy = new Giocattolo()
                        {
                            Id = reader.GetInt32(0),
                            Codice = reader.GetInt32(1),
                            Nome = reader.GetString(2),
                            Materiale = reader.GetString(3),
                            EtaMinima = reader.GetInt32(4),
                            Prezzo = reader.GetDouble(5)
                        };
                        giocattoli.Add(joy);
                    }
                }
                catch (Exception errore)
                {
                    Console.WriteLine(errore.Message);
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }

            return giocattoli;
        }

        public List<Giocattolo> GetAllRiviste()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Giocattolo obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand(); //creo il mio sql command 
                cmd.Connection = conn; // il command ha una connection che è uguale a quella configurata sopra
                cmd.CommandText = "INSERT INTO Giocattolo (nome, materiale, eta_minima, prezzo) VALUES (@nom, @mat, @eta, @pre)";
                cmd.Parameters.AddWithValue("@tit", obj.Nome);
                cmd.Parameters.AddWithValue("@cas", obj.Materiale);
                cmd.Parameters.AddWithValue("@pre", obj.EtaMinima);
                cmd.Parameters.AddWithValue("@pre", obj.Prezzo);

                try
                {
                    conn.Open();

                    int righeCoinvolte = cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CHIAMANTE: GiocattoloDAO, Messaggio: {ex.Message} ");
                }
                finally
                {
                    conn.Close();
                }

            }

            return risultato;
        }
    }
}
