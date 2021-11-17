using Microsoft.AspNetCore.Mvc;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.persistence.msql.Extensions;
using MVC_Project_Finale.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MVC_Project_Finale.Models;
using MVC_Project_Finale.common;

namespace MVC_Project_Finale.Controllers
{
    public class ProductController : Controller
    {
        private IRepository<Product> _repository;

        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ProductsViewModel p = new();
            p.listaProdotti = _repository.Get().ToList();
            return View(p);
        }
    }
}
