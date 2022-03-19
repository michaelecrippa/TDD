using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExampleTDD.Models
{
    public class Dollar
    {
        public double Amount { get; set; }

        public Dollar(double amount)
        {
            Amount = amount;
        }

        public void Times(double multiplier)
        {
            Amount *= multiplier;
        }
    }
}
