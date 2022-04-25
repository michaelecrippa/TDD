using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class TestCaseTest
    {
        private readonly WasRun test;

        public TestCaseTest(string testName = "")
        {
            test = new WasRun(testName);
            test.Run();
        }

        public void IsTestRun()
        {
            Assert.IsTrue(CustomConsole.Contains(CustomConsole.Run));
        }

        public void IsTestSetUp()
        {
            Assert.IsTrue(CustomConsole.Contains(CustomConsole.SetUp));
        }

        public void IsTestTearDown()
        {
            Assert.IsTrue(CustomConsole.Contains(CustomConsole.TearDown));
        }
    }
}
