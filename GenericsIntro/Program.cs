using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("ayşe");
            Console.WriteLine(isimler.Length);
        }

        //int sayi = 5;
        //Console.WriteLine(sayi);
        //public void kare(ref int sayi)
        //{
        //    int sonuc = sayi* sayi;
        //    Console.WriteLine(sonuc);
        //}
    }
      
}
