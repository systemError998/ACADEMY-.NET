using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_libreria.classes.DAL
{
    internal interface IDao<T>
    {
        //Interfaccia generica, a cui passerò un tipo GENERICO <T>
        //Specializzo l'interfaccia per un tipo generico che 
        //valorizzerò quando la richiamo (al posto di T, metterò il tipo di cui ho bisogno) 

        //Possiamo omettere public 
        List<T> GetAll();
        T? GetById(int Id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(T Id);

    }
}
