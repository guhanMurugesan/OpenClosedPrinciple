using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class WeighPriceRule :IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Unit.StartsWith("WEIGH");
        }
        public int Calculate(OrderItem item)
        {
            return item.Quanity * 1;
        }
    }
}
