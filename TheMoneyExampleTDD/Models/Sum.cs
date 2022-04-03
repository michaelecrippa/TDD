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

        public Expression Plus(Expression addend)
        {
            return new Sum(this, addend);
        }

        public Expression Times(int times)
        {
            return new Sum(Augend.Times(times), Addend.Times(times));
        }
    }
}
