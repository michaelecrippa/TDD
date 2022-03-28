namespace TheMoneyExampleTDD.Models.Currencies
{
    public abstract class Money
    {
        protected double Amount;

        protected string Currency { get; set; }

        public Money(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Money other = (Money)obj;

            return Amount == other.Amount && GetType().Equals(other.GetType());
        }
    }
}
