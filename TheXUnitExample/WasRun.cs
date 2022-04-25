using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class WasRun
    {
        public TestCase TestCase { get; set; }

        public WasRun(string testName = "")
        {
            TestCase = new TestCase(testName);
        }

        public void Run()
        {
            CustomConsole.Write(CustomConsole.SetUp);
            TestCase.Invoke();
            CustomConsole.Write(CustomConsole.TearDown);
        }
    }
}
