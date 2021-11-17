using MVC_Project_Finale.common;
using MVC_Project_Finale.domain;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.persistence.msql.Extensions;
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

        public CategoryRepository(string connectionString)
        {
            _context = new(connectionString);
        }

        public bool Delete(Category element)
        {
            try { _context.Categories.ProjectToDomain(); return true; }
            catch { return false; }
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories.ProjectToDomain();
        }

        public Category Insert(Category element)
        {
            element.Id = _context.Products.ProjectToDomain().Max(x => x.Id) + 1;
            _context.Add(element);
            return element;
        }

        public Category Update(Category element)
        {
            throw new NotImplementedException();
        }
    }
}
