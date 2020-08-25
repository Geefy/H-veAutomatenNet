using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveAutomatenNet
{
    public class Customer
    {
        public string Name { get; set; }
        public Card Card { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
