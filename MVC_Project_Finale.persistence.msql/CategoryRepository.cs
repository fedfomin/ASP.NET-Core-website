using MVC_Project_Finale.common;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.persistence.msql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project_Finale.persistence.msql
{
    public class CategoryRepository : IRepository<Categories>
    {
        private readonly NORTHWINDContext _context;

        public CategoryRepository(NORTHWINDContext context)
        {
            _context = context;
        }

        public Categories Create(Categories element)
        {
            throw new NotImplementedException();
        }

        public Categories Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categories Edit(Categories element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categories> Get()
        {
            throw new NotImplementedException();
        }

        public Categories Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
