using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainProject.Interfaces;
using MainProject.Services;

namespace MainProject.Classess
{
    class Cart
    {
        public List<CartItem> Items { get; } = new();

        private List<IShippable> ShippedItems { get; } = new();
        public bool IsEmpty { get { return Items.Count == 0; } }

        public void Add(Product p, int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine($"No quantity was add for Product ({p.Name}) as you haven't entered a Positive quantity!");
                return;
            }
            if (p.Quantity == 0)
            {
                Console.WriteLine($"Product ({p.Name}) is not available in the stock!");
                return;
            }
            if (p.IsExpired())
            {
                Console.WriteLine($"Sorry can't add the Product, The amount remaining of Product ({p.Name}) is Expired!");
                return;
            }

            // if product is already in the cart
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Product.GetType() == p.GetType())
                {
                    if (Items[i].Quantity + quantity > p.Quantity)
                    {
                        Console.WriteLine($"Can't add an amount of {quantity} of product {p.Name} as the Remaining amount in the stock isn't sufficient");
                    }
                    else
                    {
                        Console.WriteLine($"An amount of {quantity} of Product ({p.Name}) was added to the Cart Successfully");
                        Items[i].Quantity += quantity;
                    }
                    return;
                }
            }

            // if it's the first time to add the product
            if (quantity <= p.Quantity)
            {
                Console.WriteLine($"An amount of {quantity} of Product ({p.Name}) was added to the Cart Successfully");
                Items.Add(new CartItem(p, quantity));
                if (p is ShippableProduct sh)
                    ShippedItems.Add(sh);
            }
            else
            {
                Console.WriteLine($"Can't add an amount of {quantity} of product {p.Name} as the Remaining amount in the stock isn't sufficient");
            }
        }

        public void ShowItemsInfo()
        {
            Console.WriteLine("\n==== Checkout receipt ====\n");
            foreach (var item in Items)
            { Console.WriteLine($"Item: {item.Product.Name} | Quantity: {item.Quantity} | Price : {item.GetItemPrice()}"); }
            ShippingService.Shipping(ShippedItems);
            Console.WriteLine($"\nItems Cost: {getItemsPrice()}");
            Console.WriteLine($"\nShipping Fees: {getItemsShippingPrice()}");
            Console.WriteLine($"\nTotal Price: {getTotalPrice()}");
        }

        public double getItemsPrice()
        {
            double sum = 0;
            foreach (CartItem item in Items)
                sum += item.GetItemPrice();
            return sum;
        }
        public double getItemsShippingPrice()
        {
            double sum = 0;
            foreach (CartItem item in Items)
                sum += item.GetShippingFees();
            return sum;
        }
        public double getTotalPrice()
        {
            return getItemsPrice() + getItemsShippingPrice();
        }
        public void Clear()
        {
            Items.Clear();
            ShippedItems.Clear();
        }
    }

}
