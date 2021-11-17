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
    public class ProductRepository : IRepository<Products>
    {
        private readonly NORTHWINDContext _context;

        public ProductRepository(NORTHWINDContext context)
        {
            _context = context;
        }

        public Products Create(Products element)
        {
            throw new NotImplementedException();
        }

        public Products Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Products Edit(Products element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> Get()
        {
            throw new NotImplementedException();
        }

        public Products Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
