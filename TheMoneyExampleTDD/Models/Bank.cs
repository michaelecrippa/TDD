using TheMoneyExampleTDD.Models.Currencies;

namespace TheMoneyExampleTDD.Models
{
    public class Bank
    {
        private readonly Dictionary<KeyValuePair<string, string>, double> _exchangeRates;

        public Bank()
        {
            _exchangeRates = new Dictionary<KeyValuePair<string, string>, double>();
        }

        public void AddRate(string from, string to, double rate)
        {
            _exchangeRates.TryAdd(new KeyValuePair<string, string>(from, to), rate);
        }

        public double GetRate(string from, string to)
        {
            if (from == to)
            {
                return 1;
            }

            _exchangeRates.TryGetValue(new KeyValuePair<string, string>(from, to), out double rate);

            return rate;
        }

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }
    }
}
