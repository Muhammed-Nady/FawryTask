using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classess
{
    class CartItem
    {
        public Product Product { get; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public double GetItemPrice()
        {
            return Quantity * Product.Price;
        }

        public double GetShippingFees()
        {
            if (Product is ShippableProduct sh)
                return Quantity * sh.Weight * 3.85; // arbitrary
            return 0; // it's not shippable
        }
    }
}
