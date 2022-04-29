using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class TestCaseTest
    {
        private readonly WasRun test;

        private readonly TestResult testResult;

        public TestCaseTest(string testName = "")
        {
            test = new WasRun(testName);
            testResult = test.Run();
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

        public void TestFailedResult()
        {
            testResult.TestFailed();
            Assert.AreEqual(testResult.Summary, "0 run, 1 failed");
        }

        public void TestFailedResultFormatting()
        {
            testResult.TestStarted();
            testResult.TestFailed();

            Assert.AreEqual("1 run, 1 failed", testResult.Summary);
        }
    }
}
