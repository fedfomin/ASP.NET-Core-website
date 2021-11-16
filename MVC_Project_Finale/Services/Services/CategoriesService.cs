using MVC_Project_Finale.EF.Data;
using MVC_Project_Finale.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Services.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly NORTHWINDContext _context;

        public CategoriesService(NORTHWINDContext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
