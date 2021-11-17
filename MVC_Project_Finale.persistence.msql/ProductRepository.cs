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

        public bool Delete(int Id)
        {
            try {
                _context.Products.Remove(_context.Products.Find(Id));
                _context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products.AsQueryable().ProjectToDomain();
        }
            
        public Product Insert(Product element)
        {
            int x = _context.Products.Add(element.ProjectToModel()).Entity.ProductId;
            _context.SaveChanges();
            element.CategoryId = x;
            return element;
        }

        public Product Update(Product element)
        {
            _context.Products.Update(element.ProjectToModel());
            _context.SaveChanges();
            return element;
        }
    }
}
