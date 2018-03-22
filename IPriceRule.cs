using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        int Calculate(OrderItem item);
    }
}
