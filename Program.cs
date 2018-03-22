using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart(new PricingCalculator());
            cart.AddCart(new OrderItem("SPECIAL",2));
            Console.WriteLine(cart.TotalAmount());
            Console.ReadKey();
        }
    }
}
