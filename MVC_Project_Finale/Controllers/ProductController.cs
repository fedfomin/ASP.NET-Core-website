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

        public IActionResult Index(int page, int perPage)
        {
            if (perPage <= 0)
            {
                perPage = 8;
            }

            int n = _repository.Get().ToList().Count();
            int nPage = (n / perPage) + (n % perPage == 0 ? 0 : 1);
            int maxPage = nPage - 1;

            if (page < 0 || page > maxPage)
            {
                page = 0;
            }

            ProductsViewModel p = new();
            p.listaProdotti = _repository.Get().Skip(page * perPage).Take(perPage).ToList();
            p.MaxPage = maxPage;
            p.PerPage = perPage;
            p.ActualPage = page;

            return View(p);
        }

        public IActionResult Delete(int Id)
        {
            var q = _repository.Delete(Id);
            return RedirectToAction("Index", q);
        }
    }
}
