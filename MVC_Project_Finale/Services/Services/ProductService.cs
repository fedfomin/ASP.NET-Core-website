using MVC_Project_Finale.EF.Model;
using MVC_Project_Finale.Persistance.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Products> _productRepository;

        public ProductService(IRepository<Products> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Products> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
