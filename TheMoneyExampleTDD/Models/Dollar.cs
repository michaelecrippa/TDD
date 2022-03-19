namespace TheMoneyExampleTDD.Models
{
    public class Dollar
    {
        private double Amount;

        public Dollar(double amount)
        {
            Amount = amount;
        }

        public Dollar Times(double multiplier)
        {
            return new Dollar(Amount *= multiplier);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Dollar otherDollar = (Dollar)obj;

            return Amount == otherDollar.Amount;
        }
    }
}
