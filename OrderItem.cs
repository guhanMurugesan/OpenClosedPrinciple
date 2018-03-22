using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class OrderItem
    {
        public OrderItem(string unit,int quanity)
        {
            Unit = unit;
            Quanity = quanity;
        }
        public string Unit { get; set; }
        public int Quanity { get; set; }
    }
}
