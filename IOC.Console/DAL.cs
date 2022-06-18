using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.console
{
    public class DAL:IDAL
    {
        public List<Product> GetProducts(){
            return new List<Product>()
            {
                new Product(){ Id = 1, Name = "Product 1", Price = 1000, Stock = 150 },
                new Product(){ Id = 2, Name = "Product 2", Price = 2000, Stock = 200 },
                new Product(){ Id = 3, Name = "Product 3", Price = 3000, Stock = 250 },
                new Product(){ Id = 4, Name = "Product 4", Price = 4000, Stock = 300 },
                new Product(){ Id = 5, Name = "Product 5", Price = 5000, Stock = 350 },
                new Product(){ Id = 6, Name = "Product 6", Price = 6000, Stock = 400 },
                new Product(){ Id = 7, Name = "Product 7", Price = 7000, Stock = 450 }
            };
        }

        // This method only used in DAL class
        public float CalculateTotal()
        {
            float total = 0;

            this.GetProducts().ForEach(product =>
            {
                total += product.Price;
            });

            return total;
        }
        
    }
}