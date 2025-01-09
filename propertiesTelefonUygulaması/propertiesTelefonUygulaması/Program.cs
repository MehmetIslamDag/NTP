using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesTelefonUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon();
            telefon1.Marka = "Samsung";
            telefon1.Model = "Galaxy S21";
            telefon1.Fiyat = 20000;

            Telefon telefon2 = new Telefon();
            telefon2.Marka = "Apple";
            telefon2.Model = "İphone 15 Pro";
            telefon2.Fiyat = 50000;

            telefon1.BilgiYazdır();
            telefon1.AramaYap("0545-555-5555");
            telefon2.AramaYap("0545-456-5955");
            telefon2.BilgiYazdır();

            Console.ReadLine();
        }
    }
}
