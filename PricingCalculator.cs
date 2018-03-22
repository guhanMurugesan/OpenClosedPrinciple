using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class PricingCalculator :IPriceCalculator
    {
        private readonly IList<IPriceRule> priceRules;
        public PricingCalculator()
        {
            priceRules = new List<IPriceRule>();
            priceRules.Add(new EachPriceRule());
            priceRules.Add(new SpecialPriceRule());
            priceRules.Add(new WeighPriceRule());
        }

        public int CalulatePrice(OrderItem item)
        {
            return priceRules.First(x => x.IsMatch(item)).Calculate(item);
        }
    }
}
