using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez08_Injection.Models.DAL
{
    internal interface IDaoScrittura<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
    }
}
