using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"İnci", "Zeynep","Necip","Cemil" };// gerçek projelerde bir veri kaynağından gelir.
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; // bu işlemden sonra yukarıdaki dizinin hükmü kalmaz
            isimler[4] = "Rümeysa";
            Console.WriteLine(isimler[4]); // çalışır ama
            Console.WriteLine(isimler[0]); // bunu bir daha okumaz yeni bir dizi oluşturuldu çünkü.
            // diziler oluşturulduktan sonra bu şekilde genişletilemez eklenemez eklenirse , hükümsüz olur.
            // Arraylarda sabitlik var . new ile güncellenirse bile diğerleri kaybedilir.
            // Gerçek projelerde Çok fazla array kulanılmaz Onun Yerine KOLLEKSİYONLAR kullanılır.

            List<string> isimler2 = new List<string> { "İnci", "Zeynep", "Necip", "Cemil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Hümeyra");
            Console.WriteLine(isimler2[4]); 
            Console.WriteLine(isimler2[0]);
            // list lerin Fonksiyonlarını araştır. isimler2. yaparak faydalı metotları araştır.
        }   // list ler bir sınıftır.
    }
}
