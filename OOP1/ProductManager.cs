using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) // bu Product türünde product(bişey) ver demek.Methodu nasıl çağırıcan.
        {
            Console.WriteLine(product.ProductName + " eklendi");

        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName +" güncellendi.");
        }

     


    }
}
