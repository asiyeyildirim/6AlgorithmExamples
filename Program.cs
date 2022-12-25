using System;

namespace Odev1_IBB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*


            //SORU 1


            int sayi1, sayi2, toplam = 0;

            Console.Write("Çarpılması istenilen sayı:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Çarpılması istenilen adet:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

        
            

            for (int i = 1; i<=sayi2; i++ )
            {
               
                toplam += sayi1;
                
            }
            Console.Write("Çarpım sonucunda çıkan sayı:" + toplam,
                Console.BackgroundColor=ConsoleColor.White,
                Console.ForegroundColor=ConsoleColor.Red );
          

            Console.ReadKey();


            

            //SORU 2



            int sayi = 100; //değerimiz
            int sayac;

            for (int i = 2; i < sayi; i++) // 2'den başlayarak i 100'den küçük olana kadar dön 
            {

                sayac = 0;
                for (int j = 2; j <i; j++) // bölecek sayımız i olana kadar dön
                {
                    if (i%j == 0) //bölüm 0 ise
                    {
                        sayac++; //Sayacı 1 arttır, asal değildir artık
                    }
                    
                }
                if (sayac ==0) //bölüm hala 1 ise asal sayıdır
                {
                    Console.WriteLine( i); // asal çıkan sayıyı ekrana yaz
                }
            }
            Console.ReadLine();

          


            //SORU3

            int toplam,sayi, yuzbinler,onbinler,binler,yuzler, onlar, birler;
            Console.Write("6 basamaklı bir sayı girin : "); //kullanıcıdan sayı aldık
            sayi = Convert.ToInt32(Console.ReadLine());


            yuzbinler = sayi / 100000; //basamak çözümleme yapıyoruz
            sayi = sayi - (yuzbinler * 100000);
            onbinler = sayi / 10000;
            sayi = sayi - (onbinler * 10000);
            binler = sayi / 1000;
            sayi = sayi - (binler * 1000);
            yuzler = sayi / 100;
            sayi = sayi - (yuzler * 100);
            onlar = sayi / 10;
            sayi = sayi - (onlar * 10);
            birler = sayi;





            toplam = (yuzbinler + onbinler + binler + yuzler + onlar + birler); //çözümlenen sayı değerlerini topluyoruz, yazdırıyoruz
           
           Console.WriteLine("Sayının rakamları toplamı : {0}", toplam); 
            



            //SORU 4

            int sinav1;
            int sinav2;
            int genel_sinav;

            int gecmeNotu; 


            Console.Write("Sınav 1 notunuzu giriniz:");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sınav 1 notunuzu giriniz:");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sınav 1 notunuzu giriniz:");
            genel_sinav = Convert.ToInt32(Console.ReadLine());

            gecmeNotu = ((sinav1 * 20 / 100) +( sinav2 * 30 / 100) + (genel_sinav * 50 / 100));

            if (gecmeNotu>50)
            {
                Console.WriteLine("Tebrikler geçtiniz:" + gecmeNotu);
            }

            else{
                Console.WriteLine("Maalesef kaldınız:" + gecmeNotu);
            }


            



            //SORU 5

            int sayi, yuzler,yuzlermod, birler,binler, binlermod,fark;

            Console.Write("4 basamaklı sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            binler = sayi / 10000;
            binlermod = sayi;

            yuzler = sayi % 1000;
            yuzlermod = (yuzler % 3);


            birler = sayi % 10;

            fark = (yuzlermod - (birler));

            Console.WriteLine("Yüzler basamağı ve birler basamağının farkı: " + fark);

            */


            //SORU 6


            int para_miktari = 0;
            int p200 = 0, p100 = 0, p50 = 0, p20 = 0, p10 = 0, p5 = 0, p1 = 0;
            Console.Write("Lütfen Çekilecek Para Tutarını Giriniz: ");
            para_miktari = int.Parse(Console.ReadLine());
          
            

            //200 lük banknot adet
            if (para_miktari >= 200)
            {
                p200 = para_miktari / 200; //parayı böl
                para_miktari = para_miktari % 200; //kalan miktar için mod al
            }
            //100 lük banknot adet
            if (para_miktari >= 100)
            {
                p100 = para_miktari / 100;
                para_miktari = para_miktari % 100;
            }
            //50 lik banknot adet
            if (para_miktari >= 50)
            {
                p50 = para_miktari / 50;
                para_miktari = para_miktari % 50;
            }
            //20 lik banknot adet
            if (para_miktari >= 20)
            {
                p20 = para_miktari / 20;
                para_miktari = para_miktari % 20;
            }
            //10 luk banknot adet
            if (para_miktari >= 10)
            {
                p10 = para_miktari / 10;
                para_miktari = para_miktari % 10;
            }
            //5 lik banknot adet
            if (para_miktari >= 5)
            {
                p5 = para_miktari / 5;
                para_miktari = para_miktari % 5;
            }
          
            Console.WriteLine("200'lük verilmesi gereken banknot adedi   : " + p200);
            Console.WriteLine("100'lük verilmesi gereken banknot adedi  : " + p100);
            Console.WriteLine("50'lik verilmesi gereken banknot adedi   : " + p50);
            Console.WriteLine("20'lik verilmesi gereken banknot adedi   : " + p20);
            Console.WriteLine("10'luk verilmesi gereken banknot adedi   : " + p10);
            Console.WriteLine("5'likverilmesi gereken banknot adedi    : " + p5);
           
            Console.ReadKey();



        }
    }
}
