using System;

namespace _2.day_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Pr1 = new Product();
            Pr1.ProductName = "sweatshirt";
            Pr1.ProductPrice = 100;
            Pr1.ProductSize = 38;
            Pr1.ProductBrand = "XXX";
            Pr1.ProductColor = "blue";

            Product Pr2 = new Product();
            Pr2.ProductName = "skirt";
            Pr2.ProductPrice = 150;
            Pr2.ProductSize = 36;
            Pr2.ProductBrand = "YYY";
            Pr2.ProductColor = "pink";

            Product Pr3 = new Product();
            Pr3.ProductName = "pants";
            Pr3.ProductPrice = 200;
            Pr3.ProductSize = 40;
            Pr3.ProductBrand = "ZZZ";
            Pr3.ProductColor = "black";

            Product[] urunler = new Product[] { Pr1, Pr2, Pr3 };
            //ürünleri oluşturan dizi.

            //forech döngüsü

            foreach (var urun in urunler) 
            {
                Console.WriteLine(urun.ProductName +  "/" + urun.ProductPrice + "/" + urun.ProductSize);

            }
            //for döngüsü
            for (int i =0; i<urunler.Length ; i++) 

            {
                Console.WriteLine(urunler[i].ProductName + "/" + urunler[i].ProductBrand + "/" + urunler[i].ProductColor);
            
            }
            //while döngüsü
            int x = 0;
            while (x < urunler.Length) 
            {
                Console.WriteLine(urunler[x].ProductName + "/" + urunler[x].ProductBrand + "/" + urunler[x].ProductPrice);
                x++;
            }
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public string ProductBrand { get; set; }
        public int ProductSize { get; set; }
        public int ProductPrice { get; set; }

    }


}   



















  