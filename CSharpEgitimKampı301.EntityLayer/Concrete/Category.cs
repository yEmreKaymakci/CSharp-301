using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampı301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/*
 Field-Variable-Property
 */


/*
 int x; --> Field

 */


/*
 int x; //Class'ın içine tanımlanırsa: Field

 public int y { get; set; }//Class'ın içine get ve set'le tanımlanırsa: Property

 void test()
 {
     int z; //Methodun içine tanımlanırsa: Variable(Değişken)
 }
 
 
 */