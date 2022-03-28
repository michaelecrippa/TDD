using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMoneyExampleTDD.Models;
using TheMoneyExampleTDD.Models.Currencies;

namespace MyMoneyExampleTDD_Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void TestMutliplication()
        {
            double startingAmount = 5;
            double coefficient = 2;

            var dollar = Money.Dollar(startingAmount);
            Assert.AreEqual(Money.Dollar(startingAmount * coefficient), dollar.Times(coefficient));

            var franc = Money.Franc(startingAmount);
            Assert.AreEqual(Money.Franc(startingAmount * coefficient), franc.Times(coefficient));
        }

        [TestMethod]
        public void TestEquality()
        {
            int startingAmount = 5;

            Assert.IsTrue(Money.Dollar(startingAmount).Equals(Money.Dollar(startingAmount)));
            Assert.IsFalse(Money.Dollar(startingAmount).Equals(Money.Dollar(startingAmount + 1)));

            Assert.IsTrue(Money.Franc(startingAmount).Equals(Money.Franc(startingAmount)));
            Assert.IsFalse(Money.Franc(startingAmount).Equals(Money.Franc(startingAmount + 1)));

            Assert.IsFalse(Money.Franc(startingAmount).Equals(Money.Dollar(startingAmount)));
        }

        [TestMethod]
        public void TestAddition()
        {
            int startingAmount = 5;

            Money five = Money.Dollar(startingAmount);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(reduced, Money.Dollar(startingAmount + startingAmount));
        }
    }
}