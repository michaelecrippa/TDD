using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class TestCaseTest : TestCase
    {
        private TestResult testResult;

        public TestCaseTest(string testName = "") : base(testName)
        {
            testResult = new TestResult();
        }

        public void TestTemplateMethod()
        {
            TestCase test = WasRun.WasTestRun("testMethod");
            testResult = test.Run();
            IsTestSetUp();
            IsTestRun();
            IsTestTearDown();
        }

        public void TestResult()
        {
            TestCase test = WasRun.WasTestRun("testMethod");
            testResult = test.Run();
            Assert.AreEqual(testResult.Summary, "1 run, 0 failed");
        }

        public void TestFailedResult()
        {
            TestCase test = WasRun.WasTestRun("testBrokenMethod");
            testResult = test.Run();
            Assert.AreEqual(testResult.Summary, "0 run, 1 failed");
        }

        public void TestFailedResultFormatting()
        {
            var result = new TestResult();
            result.TestStarted();
            result.TestFailed();

            Assert.AreEqual("1 run, 1 failed", testResult.Summary);
        }

        public void TestSuite()
        {
           var suite = new TestSuite();
           suite.Add(WasRun.WasTestRun("testMethod"));
           suite.Add(WasRun.WasTestRun("testBrokenMethod"));
           testResult = suite.Run();
           Assert.AreEqual("2 run, 1 failed", testResult.Summary);
        }

        private void IsTestRun()
        {
            Assert.IsTrue(CustomConsole.Contains(TestName + '-' + CustomConsole.Run));
        }

        private void IsTestSetUp()
        {
            Assert.IsTrue(CustomConsole.Contains(TestName + '-' + CustomConsole.SetUp));
        }

        private void IsTestTearDown()
        {
            Assert.IsTrue(CustomConsole.Contains(TestName + '-' + CustomConsole.TearDown));
        }
    }
}
