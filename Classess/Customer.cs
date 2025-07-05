using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Classess
{
    class Customer
    {
        public string Name { get; }
        public double Balance { get; }
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
