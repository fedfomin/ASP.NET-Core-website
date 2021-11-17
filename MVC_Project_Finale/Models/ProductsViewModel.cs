using MVC_Project_Finale.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Models
{
    public class ProductsViewModel
    {
        public List<Product> listaProdotti;
        public List<TableItem> MyList { get; set; }
        public int MaxPage { get; set; }
        public int ActualPage { get; set; }
        public int PerPage { get; set; }
    }
}
