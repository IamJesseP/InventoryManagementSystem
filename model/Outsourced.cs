﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JessePerez.model
{
    public class OutSourced : Part
    {
        public string CompanyName { get; set; }

        public OutSourced(int id, string name, decimal price, int instock, int min, int max, string companyName)
            : base(id, name, price, instock, min, max)
        {
            this.CompanyName = companyName;
        }

        public OutSourced() { }
    }
}
