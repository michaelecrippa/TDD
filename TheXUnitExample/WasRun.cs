namespace TheXUnitExample
{
    public static class WasRun
    {
        public static TestCase WasTestRun(string testName = "")
        {
            return new TestCase(testName);
        }
    }
}
