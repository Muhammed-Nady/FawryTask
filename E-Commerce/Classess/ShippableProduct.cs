using MainProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classess
{
    abstract class ShippableProduct : Product, IShippable
    {
        public double Weight { get; }

        public ShippableProduct(string name, double price, int q, double w) : base(name, price, q) { Weight = w; }

        public string getName() { return Name; }

        public double getWeight() { return Weight; }
    }
}
