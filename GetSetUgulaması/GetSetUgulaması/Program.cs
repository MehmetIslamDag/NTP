using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUgulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba();
            a1.SetRenk("PEMBE");
            //arabanın rengini ayarladık (set)
            Console.WriteLine("İlk Arabanın Rengi : "+a1.GetRenk());
            Araba a2 = new Araba();
            a2.SetRenk("MAVİ");
            Console.WriteLine("İkinci Arabanın Rengi : "+a2.GetRenk());
            Console.ReadLine();
        }
    }
}
