using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 arkada mobilyaya denk geliyor örneğin.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { Id = 2,CategoryId=5, UnitsInStock=5,
                ProductName="kalem",UnitPrice=35 }; //böyle de tanımlanabilir.

            ProductManager productManager = new ProductManager();
            //ProductManager tipinde productManager oluşturuyosun.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //burda kamera  .referans ve değer tip farkından böyle oldu.
            //burda ise fonk yolladığın şey değişkenin adresi ve adresin üstünde değişiklik yapılıyo fonks içinde.

            //int sayi = 100;
           // productManager.BiseyYap(sayi); //burda sayi derken aslında 100 değerini veriyorsun sadece 
            //sayi değişkenini bağlamıyo!
           // Console.WriteLine(sayi) ;   //burda cevap 100 fonksiyondaki işlem sayi değişkenini değiştirmiyo.

           
        }
    }
}
