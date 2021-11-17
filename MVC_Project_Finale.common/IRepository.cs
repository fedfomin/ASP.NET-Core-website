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
        T Update(T element);
        T Insert(T element);
        bool Delete(int Id);
    }
}
