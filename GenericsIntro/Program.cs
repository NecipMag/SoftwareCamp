using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro // kendi list imizi oluşturmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<String> isimler = new MyList<String>(); // bir classın bu şekilde değişkeni oluşturuyoruz ve referans alınır
            // T Listi oluşturduk yani SString İnt Ya da Class verilebilir.
            isimler.Add("Necipp"); // listemiz String olduğu için string verdik int te olabilirdi o zaman int verirdik.

            Console.WriteLine(isimler.Lenght);

            isimler.Add("Zeynepp");

            Console.WriteLine(isimler.Lenght);

            foreach (var item in isimler.Items)
            { 
                Console.WriteLine(item);
            }

        }
    }
}
