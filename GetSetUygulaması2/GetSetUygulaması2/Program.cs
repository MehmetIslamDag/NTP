using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulaması2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // set metoduyla name özellğine değer atanıyor
            p.Name = "İslam";
            //get metoduyle name özellğinin değeri okunuyor ve ekrana yazdırılıyor
            Console.WriteLine("Kişinin Adı :  " + p.Name);
            Console.ReadLine();
        }
    }
}
