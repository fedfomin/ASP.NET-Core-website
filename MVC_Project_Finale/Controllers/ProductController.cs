using Microsoft.AspNetCore.Mvc;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MVC_Project_Finale.Models;

namespace MVC_Project_Finale.Controllers
{
    public class ProductController : Controller
    {
        NORTHWINDContext _context;

        public ProductController(NORTHWINDContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var products = _context.Products.ToList();
            return View();
        }
    }
}
