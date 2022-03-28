using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public class Sum : Expression
    {
        public Money Addend {  get; set; }

        public Money Augend { get; set; }

        public Sum(Money addend, Money augmend)
        {
            Addend = addend;
            Augend = augmend;
        }
        public Money Reduce(string to)
        {
            return new Money(Addend.Amount + Augend.Amount, to);
        }
    }
}
