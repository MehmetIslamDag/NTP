using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyuklSayi buyuk = new BuyuklSayi();
            int a = 250;
            int b = 50;
            int sonuc = buyuk.BuyukSayiyiBul(a, b);
            Console.WriteLine("büyük olan sayı : "+ sonuc);
            Console.ReadLine();
        }
    }
}
