using System;

namespace C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        { 
            #region  Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)
            /*
            Console.Write("Sayı1:");
            string veri1 = Console.ReadLine();
            Console.Write("Sayı2:");
            string veri2 = Console.ReadLine();

            int sayi1 = int.Parse(veri1);
            int sayi2 = int.Parse(veri2);

            int sonuc = (sayi1 + sayi2) % (sayi1 - sayi2);

            Console.WriteLine("Sonuç:"+sonuc);
            */
            #endregion

            #region  Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?
           /*
            Console.Write("Sayı:");
            string veri1 = Console.ReadLine();

            int sayi = int.Parse(veri1);

            int sonuc = 2 % 20 + (sayi -= 10);
            int sonuc1 = sonuc * sonuc;

            Console.WriteLine("Sonuç:"+sonuc1); 
            */
            #endregion
       
            #region  Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir?
            /*
                    Console.Write("Sayı1:");
                    string veri1 = Console.ReadLine();
                    Console.Write("Sayı2:");
                    string veri2 = Console.ReadLine();

                    int sayi1 = int.Parse(veri1);
                    int sayi2 = int.Parse(veri2);

                   int toplam = (sayi1 * sayi1) + (sayi2 * sayi2);
                   int fark = (sayi1 * sayi1) - (sayi2 * sayi2);

                   Console.WriteLine("Sonuç:"+(toplam+fark));
            */
            #endregion

            #region Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?
                 /* 
                    Console.Write("Vize:");
                    string veri1 = Console.ReadLine();
                    Console.Write("Final:");
                    string veri2 = Console.ReadLine();

                    double sayi1 = double.Parse(veri1);
                    double sayi2 = double.Parse(veri2);

                    double vize = (sayi1 * 30) / 100;
                    double final = (sayi2 * 70) / 100;

                    double sonuc = vize + final;

                    Console.WriteLine("Not Ortalaması:"+sonuc);
                */
            #endregion

            #region Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz.
            /*
                Console.Write("Ad:");
                string ad = Console.ReadLine();
                Console.Write("Soyad:");
                string soyad = Console.ReadLine();

                string hotmail = "@hotmail.com.tr";

                Console.WriteLine(ad+"."+soyad+hotmail);
            */
            #endregion
        
            #region Disaridan kenar uzunluklari girilen dikdortgenin cevre ve alan hesabini yapiniz
            /*
                    Console.Write("Uzun Kenar:");
                    string veri1 = Console.ReadLine();
                    Console.Write("Kısa Kenar:");
                    string veri2 = Console.ReadLine();

                    int uzun = int.Parse(veri1);
                    int kisa = int.Parse(veri2);

                    int cevre =  2 * (uzun + kisa);
                    int alan = uzun * kisa;

                    Console.WriteLine("Dikdörtgenin çevresi:"+cevre+"\nDiktörtgenin alanı:"+alan);
            */
            #endregion
        }
    }
}