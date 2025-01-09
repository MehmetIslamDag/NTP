using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriYonetimi y = new MusteriYonetimi();
            y.Ekle();
            y.Guncelle();

            MusteriBilgileri musteri1= new MusteriBilgileri();
            musteri1.Id = 1;
            musteri1.Ad = "İslam";
            musteri1.Soyad = "Dağ";
            musteri1.Sehir = "Mardin";

            MusteriBilgileri musteri2 = new MusteriBilgileri();
            musteri2.Id = 2;
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Dağ";
            musteri2.Sehir = "Diyarbakır";
            Console.WriteLine(musteri1.Sehir);
            Console.ReadLine();
        }
        
    }
}
