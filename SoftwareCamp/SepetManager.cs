using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCamp
{
    class SepetManager
    {
        public void Ekle(Urun urun) //PAARAMATRE BELİRTİLDİ. NE EKLENECEK ? ÜRÜN medot çok satırlı formüllü işlemlide olabilir.
        {
            Console.WriteLine(" Tebrikler... Sepete Eklendi : " + urun.Adi);
        }
        // bir Classın içinde birden fazla metot olabilir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi) // dikkat!! parametre bu metottaki gibi değil üsteki metottaki gibi verilmeli!
        { // çünkü daha sonra eklenmek istenen stok adedi özelliği giddip tüm kullanılan sayfalarda aklenmesi gerek. ama yukardakinde sadecce urun clasına özelik eklenir.!!!
            // Buna ENCAPSULATİON denir. Değiştirelebilrlik yenilenebilirlik, parametreleri bir araya derlemek
          Console.WriteLine(" Tebrikler... Sepete Eklendi : " + urunAdi);
        }

    }
}
