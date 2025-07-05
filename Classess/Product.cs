using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classess
{
        abstract class Product
        {
            public string Name { get; }
            public double Price { get; }
            public int Quantity { get; set; }

            public Product(string name, double price, int q)
            {
                Name = name;
                Price = price;
                Quantity = q;
            }

            public void updateQuantity(int value)
            {
                Quantity += value;
            }

            public abstract bool IsExpired();
        }
}
