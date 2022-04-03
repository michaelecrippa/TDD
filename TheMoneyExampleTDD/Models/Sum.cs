using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public class Sum : Expression
    {
        public Expression Addend {  get; set; }

        public Expression Augend { get; set; }

        public Sum(Expression addend, Expression augend)
        {
            Addend = addend;
            Augend = augend;
        }

        public Money Reduce(Bank bank, string to)
        {
            return new Money(Addend.Reduce(bank, to).Amount + Augend.Reduce(bank, to).Amount, to);
        }

        public Expression Plus(Expression other)
        {
            return null;
        }
    }
}
