using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Project_Finale.domain;
using MVC_Project_Finale.services.common;
using MVC_Project_Finale.common;

namespace MVC_Project_Finale.services
{
    public class ProductService : IService<Product>
    {
        private IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IQueryable<Product> Get()
        {
            return _repository.Get().AsQueryable();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product Save(Product element)
        {
            throw new NotImplementedException();
        }
    }
}
