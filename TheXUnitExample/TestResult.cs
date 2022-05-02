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
            _summary = string.Empty;
            _runCount = 0;
            _errorCount = 0;
        }

        public static TestResult operator +(TestResult thisResult, TestResult otherResult)
        {
            return new TestResult()
            {
                _errorCount = thisResult._errorCount + otherResult._errorCount,
                _runCount = thisResult._runCount + otherResult._runCount,
                _summary = string.Empty
            };
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
