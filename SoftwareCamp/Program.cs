using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır Karpuzu";

            // veriler bir veri tabanından , ya da kullanıcı girişiyle çekilir . 

            Urun[] urunler = new Urun[] { Urun1,Urun2 };

                 
            foreach (Urun urun in urunler) // var yazssakta olur , var yerine Urun yazdık, Urun artık bir veri tipi çınku classını oluşturduk. buna Type Safe --- Tip güvenliği denir.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
               
            }

            Console.WriteLine("------Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            
            sepetManager.Ekle(Urun1); // başka sayfalardada bu metodun kullanıldığı düşünülerek buraya yazıldı.
            sepetManager.Ekle(Urun2); // değişiklikte SeperMAnager CLassından metotu güncellemek bütün sayfalar güncellenir.

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
        }
    }
}

 //DRY = Dont repeat yourself - Clean Code - Best Practice (Kendini tekrar eden isler metot haline getirilir.)