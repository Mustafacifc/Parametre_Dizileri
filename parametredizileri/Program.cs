using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametredizileri
{

    class SayiIslemleri
    {
        public int Toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SayiIslemleri si = new SayiIslemleri();
            Console.WriteLine("Toplam: {0}", si.Toplam(3));
            Console.WriteLine("Toplam: {0}", si.Toplam(8, 5, 1));
            Console.WriteLine("Toplam: {0}", si.Toplam(8, 6, 4, 1, 7, 1,2,3,4,5,6,7,8,8,9));
        }
    }
}
