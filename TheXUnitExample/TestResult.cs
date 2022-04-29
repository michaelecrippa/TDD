namespace TheXUnitExample
{
    public class TestResult
    {
        private string _summary;

        public string Summary 
        {
            get => string.Format("{0} run, {1} failed", _runCount, _errorCount);
            set => _summary = value;
        }

        private int _runCount;

        private int _errorCount;

        public TestResult()
        {
            _runCount = 0;
            _errorCount = 0;
        }

        public void TestStarted()
        {
            _runCount++;
        }

        public void TestFailed()
        {
            _errorCount++;
        }
    }
}
