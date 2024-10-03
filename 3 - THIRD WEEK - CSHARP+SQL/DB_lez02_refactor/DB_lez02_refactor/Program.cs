using DB_lez02_refactor.classes;

namespace DB_lez02_refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DipendenteDAO dipendenteDAO = new DipendenteDAO();
            // dipendenteDAO.GetAll();
            dipendenteDAO.GetById(1);
        }
    }
}
