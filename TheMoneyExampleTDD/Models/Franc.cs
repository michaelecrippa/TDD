namespace TheMoneyExampleTDD.Models
{
    public class Franc
    {
        private double Amount;

        public Franc(double amount)
        {
            Amount = amount;
        }

        public Franc Times(double multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Franc other = (Franc)obj;

            return Amount == other.Amount;
        }
    }
}

