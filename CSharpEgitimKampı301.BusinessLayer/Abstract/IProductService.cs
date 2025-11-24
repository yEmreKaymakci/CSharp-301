using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampı301.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();

    }
}
