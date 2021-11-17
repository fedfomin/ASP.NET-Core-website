using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project_Finale.services.common
{
    public interface IService<T>
    {
        public IQueryable<T> Get();
        public T GetByID(int id);
        public T Save(T element);
        public bool Delete(int id);
    }
}
