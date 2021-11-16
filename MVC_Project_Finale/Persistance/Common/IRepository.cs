using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Persistance.Common
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Update(T element);
        T Create(T element);
        T Delete(T element);
        T Edit(T element);
    }
}
