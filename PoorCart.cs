using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class PoorCart
    {
        public IList<OrderItem> carts;

        public PoorCart()
        {
            carts = new List<OrderItem>();
        }

        public void AddCart(OrderItem item)
        {
            carts.Add(item);
        }

        public int TotalAmount()
        {
            var amount = 0;
            foreach (var item in carts)
            {
                if (item.Unit.StartsWith("EACH"))
                {
                    amount = item.Quanity * 4;
                }
                else if (item.Unit.StartsWith("WEIGH"))
                {
                    amount = item.Quanity * 4/1000;
                }
                else if (item.Unit.StartsWith("SPECIAL"))
                {
                    amount = item.Quanity * 4 - 1;
                }
            }
            return amount;
        }
    }
}
