namespace TheXUnitExample
{
    public class WasRun
    {
        public TestCase TestCase { get; set; }

        public WasRun(string testName = "")
        {
            TestCase = new TestCase(testName);
        }

        public TestResult Run() => TestCase.Run();
    }
}
