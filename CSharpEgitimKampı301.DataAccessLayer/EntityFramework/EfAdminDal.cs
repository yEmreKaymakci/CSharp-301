using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampı301.DataAccessLayer.Abstract;
using CSharpEgitimKampı301.DataAccessLayer.Repositories;
using CSharpEgitimKampı301.EntityLayer;

namespace CSharpEgitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
/*
 Bütün Entityler için geçerli olan methodlar: Ekle, Sil, Güncelle, Listele ve Id'ye Göre Getir
 Her Entity için geçerli olmayan methodlara örnek: İçinde A harfi  geçmeyen kullanıcıları listele
 */
