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
    public class ProductRepository : IRepository<Product>
    {
        private readonly NORTHWINDContext _context;

        public ProductRepository(string connectionString)
        {
            _context = new(connectionString);
        }

        public bool Delete(Product element)
        {
            try { _context.Products.ProjectToDomain(); return true; }
            catch { return false; }
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products.ProjectToDomain();
        }
            
        public Product Insert(Product element)
        {
            element.Id = _context.Products.ProjectToDomain().Max(x => x.Id) + 1;
            _context.Add(element);
            return element;
        }

        public Product Update(Product element)
        {
            throw new NotImplementedException();
        }
    }
}
