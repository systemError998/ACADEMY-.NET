﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal class RivistaDAO : IDaoLettura<Rivista>, IDaoScrittura<Rivista>
    {
        public List<Rivista> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Rivista> GetAllGiocattoli()
        {
            throw new NotImplementedException();
        }

        public List<Rivista> GetAllRiviste()
        {
            List<Rivista> giocattoli = new List<Rivista>();

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT rivistaId, codice, titolo, casa_editrice, prezzo FROM Rivista";

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Rivista rivi = new Rivista()
                        {
                            Id = reader.GetInt32(0),
                            Codice = reader.GetInt32(1),
                            Titolo = reader.GetString(2),
                            CasaEditrice = reader.GetString(3),
                            Prezzo = reader.GetDouble(4)
                        };
                        giocattoli.Add(rivi);
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

        public bool Insert(Rivista obj)
        {
            bool risultato = false;

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {
                SqlCommand cmd = new SqlCommand(); //creo il mio sql command 
                cmd.Connection = conn; // il command ha una connection che è uguale a quella configurata sopra
                cmd.CommandText = "INSERT INTO Rivista (titolo, casa_editrice, prezzo) VALUES (@tit, @cas @pre)";
                cmd.Parameters.AddWithValue("@tit", obj.Titolo);
                cmd.Parameters.AddWithValue("@cas", obj.CasaEditrice);
                cmd.Parameters.AddWithValue("@pre", obj.Prezzo);

                try
                {
                    conn.Open();

                    int righeCoinvolte = cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"CHIAMANTE: RivistaDAO, Messaggio: {ex.Message} ");
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
