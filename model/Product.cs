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
        //auto-implemented props

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }



        public Product(int id, string name, int instock, decimal price, int min, int max) 
        {
            this.Id = id;
            this.Name = name;
            this.InStock = instock;
            this.Price = price;
            this.Min = min;
            this.Max = max;
        }

        public Product() { }  

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

    }
}
