using MainProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Services
{

    internal class ShippingService
    {
        internal static void Shipping(List<IShippable> L)
        {
            Console.WriteLine("\nShipped Items are: ");
            foreach (var item in L)
                Console.WriteLine($"Item: {item.getName()} | Weight Per Unit: {item.getWeight():F2}KG");

        }
    }
}
