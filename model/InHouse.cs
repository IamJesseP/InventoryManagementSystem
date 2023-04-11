using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePerez.model
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }
        public InHouse(int id, string name, decimal price, int instock, int min, int max, int machineID)
            :base(id, name, price, instock, min, max)
        {
            MachineID = machineID;
        }
        public InHouse() { }
    }
}
