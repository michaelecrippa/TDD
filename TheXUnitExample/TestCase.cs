using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class TestCase
    {
        public string TestName { get; set; }

        public TestCase(string testName = "")
        {
            TestName = testName;
        }

        public TestResult Invoke()
        {
            var result = new TestResult();
            result.TestStarted();
            CustomConsole.Write(CustomConsole.SetUp);
            CustomConsole.Write(CustomConsole.Run);
            CustomConsole.Write(CustomConsole.TearDown);

            return result;
        }
    }
}
