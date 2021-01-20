using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //tipi kurs olan değişken tanımlıyosun kurs1 in tipi Kurs.ve Kursun içindeki özellikleri taşır.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "asli";
            kurs2.izlenmeOrani = 40;   //aslında bu 4 satırın hepsibir değişkeni temsil ediyo.

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "kerem";
            kurs3.izlenmeOrani = 78;

            //Console.WriteLine(kurs1.KursAdi + " :" + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 }; //bu dizi Kurs tipinde olan verileri barındırır.

            foreach (var kurs in kurslar) //tekrar tekrar dönmeye yarıyo.
            {
                Console.WriteLine(kurs.KursAdi +":"+ kurs.KursunEgitmeni);

            }
            

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }

    }

