using MVC_Project_Finale.common;
using MVC_Project_Finale.domain;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.persistence.msql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Project_Finale.persistence.msql.Extensions;

namespace MVC_Project_Finale.persistence.msql
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly NORTHWINDContext _context;
        
        public ProductRepository(NORTHWINDContext context)
        {
            _context = context;
        }

        public bool Delete(Product element)
        {
            try { _context.Products.Remove(element); return true; }
            catch { return false; }
        }

        public IEnumerable<Product> Get()
        {
            return _context.Products.AsQueryable();
        }

        public Product Insert(Product element)
        {
            element.ProductId = _context.Products.Max(x => x.ProductId) + 1;
            _context.Products.Add(element);
            return element;
        }

        public Product Update(Product element)
        {
            throw new NotImplementedException();
        }
    }
}
