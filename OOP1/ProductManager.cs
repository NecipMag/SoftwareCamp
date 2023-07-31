using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager // Operasyonlar Var.Ekleme Silme Günceleme listeleme arama ...
    {
        public void Add(Product product) // void geriye değer döndürmez return yoktur.
        {
            Console.WriteLine(" Added! : " + product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine(" Updated ! : " + product.ProductName);
        }

        //public int Topla(int sayi1, int sayi2) // void değilse return var değer döndürür.
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        //niye returne ihtiyaç var.
    }

} 
