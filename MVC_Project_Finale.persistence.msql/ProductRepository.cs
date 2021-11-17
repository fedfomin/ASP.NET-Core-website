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
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Insert(Product element)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product element)
        {
            throw new NotImplementedException();
        }
    }
}
