using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Cart
    {
        public IList<OrderItem> carts;
        private IPriceCalculator Calc;

        public Cart(IPriceCalculator pricingCalc)
        {
            carts = new List<OrderItem>();
            Calc = pricingCalc;
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
                amount+= Calc.CalulatePrice(item);
            }
            return amount;
        }
    }
}
