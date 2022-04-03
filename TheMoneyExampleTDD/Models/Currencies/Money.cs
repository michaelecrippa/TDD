namespace TheMoneyExampleTDD.Models.Currencies
{
    public class Money : Expression
    {
        public double Amount { get; private set; }

        protected string Currency { get; set; }

        public Money(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public Expression Times(double multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Money other = (Money)obj;

            return Amount == other.Amount && Currency == other.Currency;
        }

        public static Money Dollar(double amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(double amount)
        {
            return new Money(amount, "CHF");
        }

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            double rate = bank.GetRate(Currency, to);

            return new Money(Amount / rate, to);
        }

        public Expression Times(int times)
        {
            return new Money(Amount * times, Currency);
        }
    }
}
