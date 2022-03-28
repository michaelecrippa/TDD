using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public interface Expression
    {
        Money Reduce(string to); 
    }
}
