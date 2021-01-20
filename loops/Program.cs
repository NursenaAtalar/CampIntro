using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "temel kurs";
            string kurs3 = "java";
            //array -dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "temel kurs", "java","python" };

          
            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");


            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar. dizilere uygulanır!
            {
                Console.WriteLine(kurs);  //her bir elemanın takma adı kurs
            }
            Console.WriteLine("sayfa sonu");

        }
    }
}
