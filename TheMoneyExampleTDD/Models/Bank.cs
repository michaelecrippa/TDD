﻿using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(to);
        }
    }
}
