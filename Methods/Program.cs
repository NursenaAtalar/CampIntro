using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1= new Product();
            pr1.Name = "apple";
            pr1.Price = 15;
            pr1.Detail = "Amasya";
                        Product pr2 = new Product();
            pr2.Name = "banana";
            pr2.Price = 25;
            pr2.Detail = "Mersin";

            Product[] fruits = new Product[] { pr1, pr2 }; //pr1 değerleri gerçekte veri kaynagından gelir.

            foreach (Product fruit in fruits)//in fruits de fruits dizisini tek tek gez.tek tek ekrana bastıgının 
                //adıda fruit dizide ki o an gezdiği elemanın adı.bu elemanların veri tipi  Product tır.
            {
                Console.WriteLine(fruit.Name +" :"+ fruit.Price);
            }

            Console.WriteLine(".........Methods.......");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(pr1);
            sepetManager.Ekle(pr2);

            sepetManager.Ekle2("Armut","Yeşil",12);

        }
            
    }
}
