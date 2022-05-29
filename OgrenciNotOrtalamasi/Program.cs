using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            string soyad;
            double vize1;
            double vize2;
            double final;
            double ortalama;
            const double vizecarpan = 0.2;
            const double finalcarpan = 0.6;

            Console.Write("Adınız :");
            ad = Console.ReadLine();

            Console.Write("Soyadınız :");
            soyad = Console.ReadLine();

            Console.Write("1. Vize : ");
            vize1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Vize : ");
            vize2 = Double.Parse(Console.ReadLine());

            Console.Write("Final : ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = (vize1 + vize2) * vizecarpan + final * finalcarpan;

            Console.WriteLine("Sayın " + ad + " " + soyad + " , ortalamanız: " + ortalama);

            if (ortalama >=60)
            {
                Console.WriteLine("Tebrikler, geçtiniz.");
            }
            else
            {
                Console.WriteLine("Malesef, kaldınız.");
            }
            Console.ReadLine();
        }
    }
}
