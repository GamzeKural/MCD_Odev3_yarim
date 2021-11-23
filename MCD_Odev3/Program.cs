using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bu uygulama örneğimizden toplam 4 adet metot kullanmaktayız.
Bu kullandığımız metotların adları ise sırası ile; yiyecek, içecek, tatlılar ve hesap işlemlerini yerine getiren metotlardır.
Uygulamamızı kullanan kullanıcılar uygulamayı açtıklarında karşılarına menü seçenekleri çıkıyor.
Bu seçeneklerin seçimine ve toplam hesap bilgilerine göre metotlarımız devreye girip hesaplıyor. 
Sonucu da ekrana yazdırıyor.Yiyecekler 
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği"20);
            Console.WriteLine("2 - Mantı"15);
            Console.WriteLine("3 - Tavuk"10);

            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Ayran"3);
            Console.WriteLine("2 - Kola"4);
            Console.WriteLine("3 - Limonata"5);

            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç"6);
            Console.WriteLine("2 - Kazandibi"8);
            Console.WriteLine("3 - Tavuk Göğsü"10);
            */
            Console.WriteLine("Hoşgeldiniz. Lütfen menüden sipariş vermek istediğiniz bölümü seçiniz");
            Console.WriteLine("****MENÜ****");
            Console.WriteLine("1 - Yemek");
            Console.WriteLine("2 - İçecek");
            Console.WriteLine("3 - Tatlı");
            string menusecim = Console.ReadLine();
            if (menusecim=="1")
            {
               
            }
            
            




        }

        public static void yemek()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği (80 TL)");
            Console.WriteLine("2 - Mantı (50 TL)");
            Console.WriteLine("3 - Tavuk (30 TL)");
            int secim = Convert.ToInt32(Console.ReadLine());
            int hesap;
        devam:
            if (secim == 1)
            {

                Console.WriteLine("Et yemeğiniz hazırlanıyor...");
                hesap = +80;

            }
            else if (secim == 2)
            {
                Console.WriteLine("Mantınız hazırlanıyor");
                hesap = +50;
            }
            else if (secim == 3)
            {
                Console.WriteLine("Tavuğunuz hazırlanıyor");
                hesap = +30;
            }
            else
            {
                Console.WriteLine("Lütfen doğru numara giriniz.");
                goto devam;
            }
        }

            public static void icecek()
            {
                Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
                Console.WriteLine("1 - Ayran (8 TL)");
                Console.WriteLine("2 - Kola (10 TL)");
                Console.WriteLine("3 - Limonata (5 TL)");
                int secim2 = Convert.ToInt32(Console.ReadLine());
                int hesap2;
            devam2:
                if (secim2 == 1)
                {

                    Console.WriteLine("Ayranınız hazırlanıor...");
                    hesap2 = +8;

                }
                else if (secim2 == 2)
                {
                    Console.WriteLine("Kolanız hazırlanıyor");
                    hesap2 = +10;
                }
                else if (secim2 == 3)
                {
                    Console.WriteLine("Ayranınız hazırlanıyor");
                    hesap2 = +5;
                }
                else
                {
                    Console.WriteLine("Lütfen doğru numara giriniz.");
                    goto devam2;
                }

            }

        public static void tatlı()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç (15 TL)");
            Console.WriteLine("2 - Kazandibi (17 TL)");
            Console.WriteLine("3 - Tavukgöğsü (18 TL)");
            int secim3 = Convert.ToInt32(Console.ReadLine());
            int hesap3;
        devam3:
            if (secim3 == 1)
            {

                Console.WriteLine("Sütlacınız hazırlanıyor...");
                hesap3 = +8;

            }
            else if (secim3 == 2)
            {
                Console.WriteLine("Kazandibiniz hazırlanıyor");
                hesap3 = +10;
            }
            else if (secim3 == 3)
            {
                Console.WriteLine("Tavukgöğsünüz hazırlanıyor");
                hesap3 = +5;
            }
            else
            {
                Console.WriteLine("Lütfen doğru numara giriniz.");
                goto devam3;
            }


        }

    }
