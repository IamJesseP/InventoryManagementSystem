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
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int id, string name, int instock, decimal price, int max, int min) 
        {
            Id = id;
            Name = name;
            InStock = instock;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product() { }  



    }
}
