using System;
using proje.Futbol;
using proje.Kapsamli.Class;
using System.Reflection;
using proje.Cigkofteci;

namespace proje
{
    class Program
    {
        static void Main(string[] args)
        {
           Dukkan dukkan = new Dukkan();
           Kemal kemal = new Kemal();
           Mahmut mahmut = new Mahmut();
           Musteri sevan = new Musteri();

           sevan.adSoyad = "Sevan Portyan";
           sevan.corona = true;
           sevan.para = false;

           dukkan.cigkofteUret(kemal);
           dukkan.cigkofteUret(mahmut);

           kemal.yardimciOl(mahmut);
           kemal.sohbetEt(mahmut);

           dukkan.hesKodu(mahmut,sevan);
           dukkan.hesKodu(kemal,sevan);

           dukkan.cigkofteSat(kemal,sevan);
           dukkan.cigkofteSat(mahmut,sevan);


        }

        public static void fifa(){
            Lewandowski robert = new Lewandowski();
            Messi lionel = new Messi();
            KendiFutbolcunuYarat batuhan = new KendiFutbolcunuYarat();

            Console.WriteLine("\n"+lionel.Ad+" "+lionel.Soyad+":\n");

            foreach (PropertyInfo item in lionel.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name+": "+item.GetValue(lionel)}");
            }
            
            Console.WriteLine();

            Console.WriteLine("\n"+robert.Ad+" "+robert.Soyad+":\n");

            foreach(PropertyInfo item in robert.GetType().GetProperties()){
                Console.WriteLine($"{item.Name}: {item.GetValue(robert)}");
            }
        }
        public static void halland()
        {
            Forvet Halland = new Forvet();

            Halland.adSoyad = "Eric Halland";
            Halland.formaNumarasi = 99;

            Halland.ozellik = new Ozellikler
            {
                sutGucu = 89,
                agresiflik = 82,
                hiz = 87,
                hizlanma = 90,
                pasGucu = 77,
                refleks = 84,
            };

            Console.WriteLine(Halland.sutCek());
        }
    }
}
