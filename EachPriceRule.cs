using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class EachPriceRule :IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Unit.StartsWith("EACH");
        }
        public int Calculate(OrderItem item)
        {
            return item.Quanity * 4;
        }
    }
}
