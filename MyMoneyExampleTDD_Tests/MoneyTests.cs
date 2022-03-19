using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheMoneyExampleTDD.Models;

namespace MyMoneyExampleTDD_Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void TestMutliplication()
        {
            var currentAmount = 5;
            double coefficient = 2;

            var dollars = new Dollar(currentAmount);
            dollars.Times(coefficient);

            Assert.AreEqual(currentAmount * coefficient, dollars.Amount);
        }
    }
}