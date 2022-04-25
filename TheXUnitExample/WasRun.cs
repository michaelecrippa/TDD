namespace TheXUnitExample
{
    public class WasRun
    {
        private bool _WasRun;

        private bool _WasSetUp;

        public TestCase TestCase { get; set; }

        public WasRun(string testName = "")
        {
            _WasRun = false;
            _WasSetUp = true;
            TestCase = new TestCase(testName);
        }

        public bool WasTestRun()
        {
            return _WasRun;
        }

        public bool WasTestSetUp()
        {
            return _WasSetUp;
        }

        public void Run()
        {
            TestCase.Invoke();
            _WasRun = true;
        }
    }
}
