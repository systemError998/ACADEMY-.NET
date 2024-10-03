using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez08_Injection.Models.DAL
{
    internal interface IDaoLettura<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
