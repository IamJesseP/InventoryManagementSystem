using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public void RemoveAssociatedPart(int index)
        {
            AssociatedParts.RemoveAt(index);
        }
        public Part LookupAssociatedPart(int i)
        {
            int currentIndex;
            for (int j = 0; j < AssociatedParts.Count; j++)
            {
                if (AssociatedParts[j].Id.Equals(i))
                {
                    currentIndex = j;
                    return AssociatedParts[j];
                }
            }
            currentIndex = -1;
            return null;
        }
    }
}
