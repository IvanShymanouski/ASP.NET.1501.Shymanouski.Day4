using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ShopModel
{
    public static class Program
    {
        public static void Main()
        {
            IKernel ninjectKernel = new StandardKernel(new ConfigModule());
            ShoppingCart cart = ninjectKernel.Get<ShoppingCart>();
            cart.Products = new List<Product>()
                {
                    new Product {Name = "Product 1", Category = "C1", Description = "no", ProductID = 1, Price = 100},
                    new Product {Name = "Product 2", Category = "C2", Description = "no", ProductID = 2, Price = 200}
                };

            Console.WriteLine("Total price = {0}$", cart.CalculateProductTotal(10));
        }
    }
}