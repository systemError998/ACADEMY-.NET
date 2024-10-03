using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez06_task_edicola.Models.DAL
{
    internal interface IDaoScrittura<T>
    //INTERFACCIA CHE SI OCCUPERA' DELL'INTERAZIONE CON IL DATABASE MA SOLO DML

    {
        bool Insert(T obj);
    }
}
