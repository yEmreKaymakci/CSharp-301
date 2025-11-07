using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampı301.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
