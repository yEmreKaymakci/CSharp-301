// BusinessLayer/Concrete/ProductManager.cs (NASIL OLMALI)
using CSharpEgitimKampı301.BusinessLayer.Abstract;
using CSharpEgitimKampı301.DataAccessLayer.Abstract;
using CSharpEgitimKampı301.EntityLayer.Concrete;
using System.Collections.Generic;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    // --- IGenericService<Product> Metotları ---

    // Ekleme İşlemi (Artık Object yerine Product almalı)
    public void TInsert(Product entity)
    {
        // Doğrudan Product türü geldiği için casting ihtiyacı yok.
        // Veri doğrulama (Validation) burada yapılabilir.
        _productDal.Insert(entity);
    }

    // Silme İşlemi (Product türü alıyor)
    public void TDelete(Product entity)
    {
        _productDal.Delete(entity);
    }

    // Güncelleme İşlemi (Product türü alıyor)
    public void TUpdate(Product entity)
    {
        // Burayı uygulamalıyız
        _productDal.Update(entity);
    }

    // ID'ye göre Getirme
    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }

    // Tümünü Getirme
    public List<Product> TGetAll()
    {
        return _productDal.GetAll();
    }

    // --- IProductService'e Özel Metotlar ---

    // Kategoriyle Birlikte Ürünleri Getirme (Object veya DTO kullanabilir)
    public List<object> TGetProductsWithCategory()
    {
        return _productDal.GetProductsWithCategory();
    }
}