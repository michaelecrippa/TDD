namespace TheXUnitExample
{
    public class TestSuite
    {
        private readonly List<TestCase> tests;

        public TestSuite()
        {
            tests = new List<TestCase>();
        }

        public void Add(TestCase test)
        {
            tests.Add(test);
        }

        public TestResult Run()
        {
            return tests.Select(test => test.Run())
                .Aggregate((TestResult curr, TestResult next) => curr + next);
        }
    }
}
