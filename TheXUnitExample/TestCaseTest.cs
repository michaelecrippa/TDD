using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheXUnitExample
{
    public class TestCaseTest
    {
        private readonly WasRun test;

        public TestCaseTest(string testName = "")
        {
            test = new WasRun(testName);
            Assert.IsFalse(test.WasTestRun());
            test.Run();
            Assert.IsTrue(test.WasTestRun());
        }
    }
}
