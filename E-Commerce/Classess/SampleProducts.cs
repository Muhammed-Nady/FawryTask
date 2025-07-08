using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classess
{
    class Cheese : ShippableProduct
    {
        DateTime ExpireDate;

        public Cheese(string name, double price, int quantity, double weight, DateTime expireDate) : base(name, price, quantity, weight) { ExpireDate = expireDate; }

        public override bool IsExpired() { return ExpireDate < DateTime.Now; }
    }

    class Biscuits : ShippableProduct
    {
        private DateTime ExpireDate;

        public Biscuits(string name, double price, int quantity, double weight, DateTime expireDate)
            : base(name, price, quantity, weight) { ExpireDate = expireDate; }

        public override bool IsExpired() { return DateTime.Now > ExpireDate; }
    }

    class TV : ShippableProduct
    {
        public TV(string name, double price, int quantity, double weight) : base(name, price, quantity, weight) { }
        public override bool IsExpired() { return false; }
    }

    class MobileScratchCard : Product
    {
        public MobileScratchCard(string name, double price, int quantity) : base(name, price, quantity) { }

        public override bool IsExpired() { return false; }
    }
}
