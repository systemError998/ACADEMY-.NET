using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez08_Injection.Models.DAL
{
    internal class UtenteDAO : IDaoLettura<Utente>
    {
        private static UtenteDAO? instance;
        public static UtenteDAO GetInstance() {
            if (instance == null) {
                instance = new UtenteDAO();
                return instance;
            } 
        } 

        private UtenteDAO() { }

        public List<Utente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetByCredenziali(string varUser, string varPass) 
        { 

            using (SqlConnection conn = new SqlConnection(Config.credenziali))
            {

                string query = $"SELECT utenteID, username, passw, ruolo FROM Utente WHERE username = '{varUser}' AND passw = '{varPass}' ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT utenteID, username, passw, ruolo FROM Utente WHERE username = @us AND passw = @pw ";

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) {
                        Utente temp = new Utente()
                        {
                            Id = dr.GetInt32(0),
                            Username = dr.GetString(1),
                            Password = dr.GetString(2),
                            Ruolo = dr.GetString(3),
                        };  
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                finally
                { 
                    conn.Close();
                }


            }
        }
    }
}
