using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulaması3
{
    class Program
    {
        static void Main(string[] args)
        {
            ucgen u = new ucgen();
            u.A = 22;
            u.B = 5;
            u.C = 8;
                int cevre = u.CevreHesapla();
            
            Console.WriteLine("Üçgenin Çeveresinin Toplamı : " + u.CevreHesapla());
            Console.ReadLine();
        }
    }
}
