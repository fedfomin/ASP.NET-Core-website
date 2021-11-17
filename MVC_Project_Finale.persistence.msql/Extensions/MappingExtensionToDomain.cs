using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Project_Finale.persistence.msql.Models;
using MVC_Project_Finale.domain;

namespace MVC_Project_Finale.persistence.msql.Extensions
{
    internal static class MappingExtensionToDomain
    {
        internal static IEnumerable<Product> ProjectToDomain(this IQueryable<Products> query)
        {
            return query.Select(x => new Product()
            {
                Id = x.ProductId,
                Name = x.ProductName,
                SupplierId = x.SupplierId,
                CategoryId = x.CategoryId,
                QuantityPerUnit = x.QuantityPerUnit,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                UnitsOnOrder = x.UnitsOnOrder,
                ReorderLevel = x.ReorderLevel,
                Discontinued = x.Discontinued
            });
        }
        internal static IEnumerable<Category> ProjectToDomain(this IQueryable<Categories> query)
        {
            return query.Select(x => new Category()
            {
                Id = x.CategoryId,
                Name = x.CategoryName,
                Description = x.Description,
                Picture = x.Picture
            });
        }
    }
}
