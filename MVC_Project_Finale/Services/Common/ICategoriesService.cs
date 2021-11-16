using MVC_Project_Finale.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Services
{
    public interface ICategoriesService
    {
        public IEnumerable<Categories> GetAll();
    }
}
