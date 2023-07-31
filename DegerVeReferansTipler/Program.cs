using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;

            // sayı1 ? 30 değer tip

            int[] sayılar1 = new int[] {10,20,30};
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;

            // sayılar1[0] ? 999 referans tip 
        }
    }
}
// sayısal veri tipleri = int, decimal,float,double,bool(0,1) bunlar DEĞER TİP
//Array,class ,inteface..= REFERANS TİP
/*
 * STACK               HEAP
 * 
 Değer tipler            
 sayı1 =10 - 30        burda yok
 sayı2 =30 - 65        burda yok

SADECE SAYI2 DEĞERİ DEĞİŞİR. SAYI1 30 DUR.
 
 Referans tip           
 101- sayı1         101 [10,20,30]  --> 102 [100,200,300]
 102- sayı2         102 [100,200,300]-->102 [100,200,300]

sayılar1=sayılar2
102=102  ---> referansları eşitlenir.

sayı2[0]=999      102 [999,200,300]

Sayı1[0] = sorulunca refarans değeri 102 idi. 102 -->[999,200,300)

sonuc=999 olur.

ÇÖP TOPLAYICI GELİR 101 İ BELLEKTEN ATAR.
 */