namespace TheMoneyExampleTDD.Models.Currencies
{
    public class Dollar : Money
    {
       public Dollar(double amount) : base(amount, "USD") { }

       public Dollar Times(double multiplier)
       {
           return new Dollar(Amount * multiplier);
       }
    }
}
