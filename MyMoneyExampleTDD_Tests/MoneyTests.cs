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

        [TestMethod]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");

            Assert.AreEqual(result, Money.Dollar(1));
        }

        [TestMethod]
        public void TestReduceDifferentCurrencies()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");

            Assert.AreEqual(result, Money.Dollar(1));
        }

        [TestMethod]
        public void TestIdentityRate()
        {
            Assert.AreEqual(new Bank().GetRate("USD", "USD"), 1.0);
        }

        [TestMethod]
        public void TestMixedAddition()
        {
            Expression five = Money.Dollar(5);
            Expression ten = Money.Franc(10);
            var bank = new Bank();

            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(five.Plus(ten), "USD");
            Assert.AreEqual(Money.Dollar(10), result);
        }

        [TestMethod]
        public void TestSumPlusMoney()
        {
            Expression five = Money.Dollar(5);
            Expression ten = Money.Franc(10);
            var bank = new Bank();

            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(five, ten).Plus(five);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(15), result);
        }

        [TestMethod]
        public void TestSumTimes()
        {
            Expression five = Money.Dollar(5);
            Expression ten = Money.Franc(10);
            var bank = new Bank();

            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(five, ten).Times(2);
            Money result = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(20), result);
        }
    }
}