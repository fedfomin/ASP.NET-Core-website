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

        public bool Delete(int Id)
        {
            try
            {
                _context.Categories.Remove(_context.Categories.Find(Id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories.ProjectToDomain();
        }

        public Category Insert(Category element)
        {
            int x = _context.Categories.Add(element.ProjectToModel()).Entity.CategoryId;
            _context.SaveChanges();
            element.Id = x;
            return element;
        }

        public Category Update(Category element)
        {
            _context.Categories.Update(element.ProjectToModel());
            _context.SaveChanges();
            return element;
        }
    }
}
