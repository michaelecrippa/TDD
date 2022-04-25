using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheXUnitExample
{
    public class TestCaseTest
    {
        private readonly WasRun test;

        public TestCaseTest(string testName = "")
        {
            test = new WasRun(testName);
        }

        public void TestRun()
        {
            Assert.IsFalse(test.WasTestRun());
            test.Run();
            Assert.IsTrue(test.WasTestRun());
        }

        public void TestSetUp()
        {
            test.Run();
            Assert.IsTrue(test.WasTestSetUp());
        }
    }
}
