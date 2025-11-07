using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampı301.BusinessLayer.Abstract;
using CSharpEgitimKampı301.DataAccessLayer.Abstract;
using CSharpEgitimKampı301.EntityLayer.Concrete;

namespace CSharpEgitimKampı301.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public void TDelete(object entity)
        {
            throw new NotImplementedException();
        }   

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        
        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

       

        List<object> IGenericService<object>.TGetAll()
        {
            throw new NotImplementedException();
        }

        object IGenericService<object>.TGetById(int id)
        {
            return TGetById(id);
        }
    }
}
