using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUygulaması3
{
    class ucgen
    {
        int a;
        int b;
        int c;
        public int A
        {
            get { return a; }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Hatalı Değer !");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Değer !");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Değer !");
                }
                else
                {
                    c = value;
                }
            }
        }
        public int CevreHesapla()
        {
            return A + B + C;
        }
        
    }
}
