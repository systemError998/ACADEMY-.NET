using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_lez04_Contatti.Models.DAL
{
    class ContattoDAO : IDao<Contatto>
    {
        private static ContattoDAO? instance;

        public static ContattoDAO GetInstance()
        {
            if (instance == null)
                instance = new ContattoDAO();

            return instance;
        }

        private ContattoDAO() { }
        public List<Contatto> GetAll()
        {
            List<Contatto> contatti = new List<Contatto>();

            //vado a leggere il contesto, che sta comunicando con il mio db
            using (var contesto = new Lez03RubricaContext()) {
                contatti = contesto.Contattos.ToList();
            }

                return contatti;
        }

        public Contatto? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Contatto t)
        {
            bool ris = false;
            using (var contesto = new Lez03RubricaContext())
            {
                try
                {
                    contesto.Contattos.Add(t);
                    contesto.SaveChanges();
                    ris = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("errore di inserimento");
                    throw;
                }
            }
            return ris;
        }
    }
}
