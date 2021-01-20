using System;

namespace Degervereferanstip
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 50;   
            Console.WriteLine(sayi1);  //sayi1=30 dur en son.çünkü burdaki veri türü int ve int değer tipidir.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar2[0]); //sayilar[0]=999 dur.array dizi yani referans tipidir. new demek bellekte yeni adres oluştur.

            //değer tipte direk değeri ata.referans tiplerde taımlarken referans adresi,numarası veriyosun.
        }
    }
}
