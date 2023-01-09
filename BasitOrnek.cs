using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12._1_DizeDegismezleriVeSabitTanimlama
{
    class BasitOrnek
    {
        static void Main(string[] args)
        //bir type'a bağlı olarak ekstra methot kullanma
        {
            var ifade = "Merhaba Programlama Dunyasi.";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length); //ifadenin uzunluğu
            Console.WriteLine(ifade.ToUpper()); //ifadeyi büyüterek verme
            Console.WriteLine(ifade.ToLower()); //ifadeyi küçülterek verme
            Console.WriteLine(ifade.TrimStart()); //boşlukları kes baştaki
            Console.WriteLine(ifade.TrimEnd()); //boşlukları kes sondaki
            Console.WriteLine(ifade.Trim(ifade[0]));
            Console.WriteLine(ifade.Trim(ifade[1]));
            Console.WriteLine(ifade.Trim(ifade[ifade.Length - 1]));

            Console.ReadKey();
        }
    }
}
