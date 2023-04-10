using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePerez.model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }

        public static BindingList<Product> products = new BindingList<Product>();

        static Product()
        {
            products.Add(
                new Product { Id = 0, Name = "Wheel", Inventory = 12, Price = 12 }
                );
            products.Add(
                new Product { Id = 1, Name = "Pedal", Inventory = 10, Price = 1 }
                );
            products.Add(
                new Product { Id = 2, Name = "Chain", Inventory = 9, Price = 7 }
                );
        }


    }
}
