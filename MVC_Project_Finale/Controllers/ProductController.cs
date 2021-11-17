using Microsoft.AspNetCore.Mvc;
using MVC_Project_Finale.persistence.msql.Data;
using MVC_Project_Finale.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MVC_Project_Finale.Controllers
{
    public class ProductController : Controller
    {
        private NORTHWINDContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, NORTHWINDContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
