using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Loops
{
    public class PrintProduct
    {
        public static List<Product> products = new List<Product>();

        /*IList<Product> productsList = new List<Product>(){
            new Product(){ Id = 1, Name = "Patatas", Price = 24.56f },
           new Product(){ Id = 2, Name = "Vinagre", Price = 35.30f },
           new Product(){ Id = 3, Name = "Juego", Price = 39.45f },
        };*/

        public static void CreateList()
        {
            /*var potatoes = new Product();
            potatoes.Id = 1;
            potatoes.Name = "Patatas";
            potatoes.Price = 24.56f;
            products.Add(potatoes);*/

        var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Vinagre",
                Price = 35.30f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 2,
                Name = "Juego",
                Price = 39.45f
            };
            products.Add(game);
        }

        public static List<Product> GetProductsGreaterThan30WithForEach()
        {
            var productsGreaterThan30 = new List<Product>();
            foreach (var product in products)
            {
                if(product.Price > 30.00f)
                {
                    productsGreaterThan30.Add(product);
                }
            }
            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithLinQ()
        {
            IEnumerable<Product> productGreaterThan30 = 
                from product in products
                where product.Price > 30.00f
                select product;
            return productGreaterThan30.ToList();
        }
    }
}
