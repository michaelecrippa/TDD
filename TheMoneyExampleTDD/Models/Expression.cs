using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);

        Expression Plus(Expression addend);

        Expression Times(int times);
    }
}
