using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        // SOLID
        // Open Closed Principle
        // Yaptığın yazılıma yeni bir özellik ekliyorsan(iş kuralı anlamında değil)++
        // ++mevcuttaki hiç bir koduna dokunamazsın.
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllUnitPrice(10,100))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
