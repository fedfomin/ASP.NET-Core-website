using MVC_Project_Finale.common;
using MVC_Project_Finale.domain;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.persistence.msql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project_Finale.persistence.msql
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly NORTHWINDContext _context;

        public CategoryRepository(NORTHWINDContext context)
        {
            _context = context;
        }

        public bool Delete(Category element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get()
        {
            throw new NotImplementedException();
        }

        public Category Insert(Category element)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category element)
        {
            throw new NotImplementedException();
        }
    }
}
