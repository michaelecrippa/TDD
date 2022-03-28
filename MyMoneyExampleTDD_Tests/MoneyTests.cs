using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMoneyExampleTDD.Models.Currencies;
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

            var dolar = new Dollar(startingAmount);
            Assert.AreEqual(new Dollar(startingAmount * coefficient), dolar.Times(coefficient));
            Assert.AreEqual(
                new Dollar(startingAmount * Math.Pow(coefficient, 2)),
                dolar.Times(Math.Pow(coefficient, 2))
                );

            var franc = new Franc(startingAmount);
            Assert.AreEqual(new Franc(startingAmount * coefficient), franc.Times(coefficient));
            Assert.AreEqual(
                new Franc(startingAmount * Math.Pow(coefficient, 2)),
                franc.Times(Math.Pow(coefficient, 2))
                );
        }

        [TestMethod]
        public void TestEquality()
        {
            int startingAmount = 5;

            Assert.IsTrue(new Dollar(startingAmount).Equals(new Dollar(startingAmount)));
            Assert.IsFalse(new Dollar(startingAmount).Equals(new Dollar(startingAmount + 1)));

            Assert.IsTrue(new Franc(startingAmount).Equals(new Franc(startingAmount)));
            Assert.IsFalse(new Franc(startingAmount).Equals(new Franc(startingAmount + 1)));

            TestDifferentCurrencyEquality<Dollar, Franc>(startingAmount);
        }

        [TestMethod]
        private void TestDifferentCurrencyEquality<T, U>(double startingAmount) 
            where T : Dollar
            where U : Franc
        {
            Assert.IsFalse(new Dollar(startingAmount).Equals(new Franc(startingAmount)));
        }
    }
}