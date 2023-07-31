using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> // List Kullanmadan kendi listimizi oluşturmak.String dışında int,boolen,class bile konur <> arasına. 
                    // Generic Class Çalışacağımız özel bir TİP olacağını Beelirtir. <T> T=Type ama T yerine istenilen yazılabilir.
                    // MyListimde T ile çalışacağım.
    {
        T[] items; // T tipinde bir array - dizi tanımladık Clas için Metot Dışına. Clastaki Her Metotta Görülür.
                   // Arrayı NEW lemek gerekiyor. Yani Oluşturmak Bellekte Referans Etmek HEAPta.
                   // NEW lenince sıfır elemanlı bir dizi oluşturulmuş oluruz.
            
        public MyList() // Ctor yaz tab tab ile Bu blok oluşturulur.Buna CONSTRUCTOR DENİR.!!! Bir metodtur. Classın adı ile aynıdır.
                        // Bİr yerde CLASS NEW lenirse Bu Otomatik çalışıyor.
        {
            items = new T[0]; // İtems burda newlenir. class new lenirse böylece elemanlı dizi oluşmuş olur otomatik.
            // elimizde artık sıfır elemanlı bir dizi var atrık diziye eleman eklenebilir.

        }
        public void Add(T İtem) // item = Eleman T = Programcı hangi tipte eleman verirse ona göre çalıştır demek. Ekleme işlemi için Classı New lemek gerek. Class New leyince otomatik oluşan dizi constructor bloğu ile çalışır.
        {
            T[] tempArray = items;   // geçicidizinin referansı = items in referansı yapılır.Artık elemanlar kaybolmaz onu geçici emanet ettik.                       // new lenenin referansını birine tutturmak lazım.
            items =  new T[items.Length+1]; // dizinin Elemean sayısı 1 arttırmak için newlwmwk zorunlu. mevcut eleman sayısına 1 eklendi
                                            // NOT : NEW lenen herşeyin referan numarası uçar önceki kayıt hafızada tutulmaz bunun önüne geçilmeli.

            // tempArray a tutturduğumuz elemanları geri isteyelim.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = İtem; // aslında eklenmek istenen son boşluktaki yere eleman şuan eklendi.

        }
        public int Lenght 
        {
            get { return items.Length; }        
        }

        public T[] Items

        { 
            get { return items; } 
        }   

    }
}
