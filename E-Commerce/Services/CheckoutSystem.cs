using MainProject.Classess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Services
{
    internal class CheckoutSystem
    {
        internal static void Checkout(Customer customer, Cart cart)
        {
            if (customer.Balance < cart.getTotalPrice())
            {
                Console.WriteLine("Customer's Balance isn't sufficient to Complete the Checkout Process");
                return;
            }
            if (cart.Items.Count == 0)
            {
                Console.WriteLine("The Cart is Empty\nCheckout Process can't Proceed");
                return;
            }
            Console.WriteLine("\nCheckout Process has done Successfully!");
            cart.ShowItemsInfo();
            Console.WriteLine($"\nCustomer Current Balance: {customer.Balance - cart.getTotalPrice():F2}\n");
            Console.WriteLine($"=========================\n");
            for (int i = 0; i < cart.Items.Count; i++)
                cart.Items[i].Product.updateQuantity(-cart.Items[i].Quantity);
            cart.Clear();
        }
    }
}
