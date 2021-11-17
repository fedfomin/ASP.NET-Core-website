using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project_Finale.common
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Update(int id);
        T Create(T element);
        T Edit(T element);
        T Delete(int id);
    }
}
