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
            int startingAmount = 5;
            double coefficient = 2;
            Dollar fiveDollars = new Dollar(startingAmount);

            Assert.AreEqual(new Dollar(startingAmount * coefficient), fiveDollars.Times(coefficient));
            Assert.AreEqual(
                new Dollar(startingAmount * Math.Pow(coefficient, 2)),
                fiveDollars.Times(Math.Pow(coefficient, 2))
                );
        }

        [TestMethod]
        public void TestEquality()
        {
            int startingAmount = 5;

            Assert.IsTrue(new Dollar(startingAmount).Equals(new Dollar(startingAmount)));
            Assert.IsFalse(new Dollar(startingAmount).Equals(new Dollar(startingAmount + 1)));
        }

        [TestMethod]
        public void TestFrancMutliplication()
        {
            int startingAmount = 5;
            double coefficient = 2;
            Franc fiveFrancs = new Franc(startingAmount);

            Assert.AreEqual(new Franc(startingAmount * coefficient), fiveFrancs.Times(coefficient));
            Assert.AreEqual(
                new Franc(startingAmount * Math.Pow(coefficient, 2)),
                fiveFrancs.Times(Math.Pow(coefficient, 2))
                );
        }
    }
}