using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePerez.model
{
    internal class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public int Price { get; set; }

        public static BindingList<Part> parts = new BindingList<Part>();

        static Part()
        {
            parts.Add(
                new Part { Id = 0, Name = "Wheel", Inventory = 12, Price = 12 }
                );
            parts.Add(
                new Part { Id = 1, Name = "Chain", Inventory = 10, Price = 10 }
                );
            parts.Add(
                new Part { Id = 2, Name = "Pedal", Inventory = 9, Price = 7 }
                );
        }


    }
}
