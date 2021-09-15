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
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        public static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("Ürün Adı: " + product.ProductName + " | Kategori Adı: " + product.CategoryName);
            }
        }
    }
}
