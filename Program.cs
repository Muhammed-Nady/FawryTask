using MainProject.Classess;
using MainProject.Services;

namespace FawryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheese Cheese = new("cheese", 12, 100, 0.25, new(2025, 7, 15));
            Biscuits Biscuits = new("biscuits", 5, 500, 0.2, new(2027, 7, 5));
            TV TV = new("tv", 3400, 20, 10);
            MobileScratchCard MSC = new("MobileScratchCard", 50, 70);

            Cart myCart = new Cart();
            myCart.Add(Cheese, 20);
            myCart.Add(Cheese, 90); //can't add in the stock
            myCart.Add(Biscuits, 7);
            myCart.Add(TV, 2);
            myCart.Add(MSC, 5);

            Customer c = new("Mohammed", 10000);

            CheckoutSystem.Checkout(c ,myCart);
        }
    }
}
