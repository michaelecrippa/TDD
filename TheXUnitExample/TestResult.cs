namespace TheXUnitExample
{
    public class TestResult
    {
        private string _summary;

        public string Summary {
            get
            {
                return String.Format("{0} run, {1} failed {2}", 0, 0, _counter);
            }
            set => _summary = value;
        }

        private int _counter;

        public TestResult()
        {
            Summary = "mock summary";
            _counter = 0;
        }

        public void TestStarted()
        {
            _counter++;
        }
    }
}
