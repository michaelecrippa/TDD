namespace TheMoneyExampleTDD.Models.Currencies
{
    public class Franc : Money
    {
        public Franc(double amount) : base(amount, "CHF") { }

        public Franc Times(double multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}

