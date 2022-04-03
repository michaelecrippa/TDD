namespace TheXUnitExample
{
    public class WasRun
    {
        private bool _WasRun;

        public TestCase TestCase { get; set; }

        public WasRun(string testName = "")
        {
            _WasRun = false;
            TestCase = new TestCase(testName);
        }

        public bool WasTestRun()
        {
            return _WasRun;
        }

        public void Run()
        {
            TestCase.Invoke();
            _WasRun = true;
        }
    }
}
