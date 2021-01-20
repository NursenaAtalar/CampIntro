using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; //int belli sınırları vardır daha büyük sayı için 
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true; //gerçek hayatta bu değer bir veri kaynagından gelir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");

            }


            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }


               





        }
    }
}
