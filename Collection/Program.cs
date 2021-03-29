using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Engin ","murat","halil","kerem" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5]; //5 boş elemanlı dizi referans num al. 
            //names[4] = "İlker";  
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);

            List<string> names2 = new List<string> { "Engin ", "murat", "halil", "kerem" };
            Console.WriteLine(names2[0]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

           




        }
    }
}
