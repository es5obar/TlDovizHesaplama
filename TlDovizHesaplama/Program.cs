using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlDovizHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.başla
             * 2.kullanıcıdan tl cinsinden para girilmesi istenir.
             * 3.kullanıcı para girer.
             * 4.kullanıcıdan para birimi girilmesi istenir.(dolar :d , euro: e , Pound: p)
             * 5.1.Eğer para birimi dolar ise
             * 5.2.kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
             * 5.3.eğer para birimi euro ise
             * 5.4.kullanıcının girdiği parayı tanımlı olan euro kuruna böl
             * 5.5.eğer para birimi pound ise
             * 5.6.kullanıcının girdiği parayı tanımlı olan pound kuruna böl
             * 5.7.eğer para birimi dolar , euro ve pound değilse
             * 5.8.kullanıcıdan doğru tanımlı para birimi girilmesi istenir
             * 6.hesaplama sonucu ekrana yazdır.
             * 7.bitir
             */
            double tl;
            string paraBirimi;
            double dolar = 10, euro = 11.4, pound = 13;
            string tarih = "13.11.2021";
            double sonuc;

            Console.Write("TL cinsinden para giriniz :");
            tl = Convert.ToDouble(Console.ReadLine());

            Console.Write("Para birimi giriniz  (d :dolar , e: euro , p: pound ) :");
            paraBirimi = Console.ReadLine();

            //if(paraBirimi != "d" && paraBirimi !="e" && paraBirimi !="p")
            if (!(paraBirimi == "d" || paraBirimi == "e" || paraBirimi == "p"))
            {
                Console.WriteLine("Adam ol doğru giriş yap!");
            }
            else
            {
                
                if (paraBirimi =="d")
                {
                    sonuc = tl / dolar;
                }
                else if (paraBirimi == "e")
                {
                    sonuc = tl / euro;
                }
                else
                {
                    sonuc = tl / pound;
                }
                Console.WriteLine("Tarih : " + tarih + "\nDövizSonucu : " + sonuc);
            }
            Console.ReadLine();
        }
    }
}
