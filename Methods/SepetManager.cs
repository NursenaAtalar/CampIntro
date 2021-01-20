using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun) //product classından urun ekle demek. daha sora fonk cagırırken () içinde hangi urun old yazıyosun.
        {
            Console.WriteLine("Tebrikler ,sepete eklendi : " + urun.Name);

        }
        //bir classın içinde birden fazla method olabilir.
        public void Ekle2(string urunName, string Detail, double Price) //class olmadan döyle yazılıp daha sonra cagrılabilir.
            //AMA!!!!! bir düzeltme yapılması gerektiğinde her yerden düzeltmen gerek.
        {
            Console.WriteLine("Tebrikler ,sepete eklendi : " + urunName);

        }

    }
}
