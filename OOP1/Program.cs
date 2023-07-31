using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // mobilya
            product1.ProductName = "Masa"; //tbxProductName Textbox tan alınır normalde.
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            // categoryId=5 --> Kırtasiye
            Product product2 = new Product {Id=2, CategoryId =5,
                UnitsInStock=5,ProductName="Kanepe",UnitPrice=35 };

            //gerçek projede Değerler Kullanıcıdan Alınır. Textbox,Label,SQL,WEB...


            //pascalCase    //camelCase
            ProductManager productManager= new ProductManager(); // Örnek oluşturma-Nesne olusturma Referans tip oluşturmak içiin onu new lemek gerek
            productManager.Add(product1);


            //productManager.Topla2(3, 6); // void ile gelen bu toplam sonucunu kullanmak istediğimizde 
            //// program akışında çarmaada kullanmak istersek o değeri kullanamayız.void gösterir işini bitirir.
            //// programının akışında o değer lazım olduğunda kullanamayız metod olarak çalışır çünkü.

            //int toplamaSonucu = productManager.Topla(3,6); // int ile gelen topla değerini int olarak kullanabiliyoruz.
            //Console.WriteLine(toplamaSonucu * 2); // iişte bunun için return ler kullanılır.
        }
    }
}
