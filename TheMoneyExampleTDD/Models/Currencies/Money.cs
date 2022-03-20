namespace TheMoneyExampleTDD.Models.Currencies
{
    public class Money
    {
        protected double Amount;

        public Money(double amount)
        {
            Amount = amount;
        }

        public Money Times(double multiplier)
        {
            return new Money(Amount * multiplier);
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
