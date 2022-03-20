using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMoneyExampleTDD.Models;
using System;

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

            TestCurrencyMultiplication<Dollar>(startingAmount, coefficient);
            TestCurrencyMultiplication<Franc>(startingAmount, coefficient);
        }

        [TestMethod]
        public void TestEquality()
        {
            int startingAmount = 5;

            TestCurrencyEquality<Dollar>(startingAmount);
            TestCurrencyEquality<Franc>(startingAmount);
        }

        [TestMethod]
        private void TestCurrencyMultiplication<T>(double startingAmount, double coefficient) where T : Money
        {
            var currentCurrencyValue = new Money(startingAmount);
            Assert.AreEqual(new Money(startingAmount * coefficient), currentCurrencyValue.Times(coefficient));
            Assert.AreEqual(
                new Money(startingAmount * Math.Pow(coefficient, 2)),
                currentCurrencyValue.Times(Math.Pow(coefficient, 2))
                );
        }

        [TestMethod]
        private void TestCurrencyEquality<T>(double startingAmount) where T : Money
        {
            Assert.IsTrue(new Money(startingAmount).Equals(new Money(startingAmount)));
            Assert.IsFalse(new Money(startingAmount).Equals(new Money(startingAmount + 1)));
        }
    }
}