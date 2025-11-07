using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampı301.DataAccessLayer.Abstract;
using CSharpEgitimKampı301.DataAccessLayer.Context;
using CSharpEgitimKampı301.DataAccessLayer.Repositories;
using CSharpEgitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();
            return values.Cast<object>().ToList() ;
        }
    }
}
