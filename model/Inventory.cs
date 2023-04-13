using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePerez.model
{
    public class Inventory
    {
        public static BindingList<Part> FullParts = new BindingList<Part>();
        public static BindingList<Product> FullProducts = new BindingList<Product>();

        public static void SampleInventoryData() 
        {
            Part samplePart1 = new InHouse(1, "Screw", 12, 3, 3, 9, 2990);
            Part samplePart2 = new InHouse(2, "Nail", 6, 1, 1, 8, 2991);
            Part samplePart3 = new InHouse(3, "Washer", 5.00M, 10, 1, 10, 2992);
        
            FullParts.Add(samplePart1);
            FullParts.Add(samplePart2);
            FullParts.Add(samplePart3);

            Product sampleProduct1 = new Product(1, "Bike", 5, 12.00M, 2, 8);

            FullProducts.Add(sampleProduct1);

            sampleProduct1.AssociatedParts.Add(samplePart1);
            sampleProduct1.AssociatedParts.Add(samplePart2);

        }


    }
}
