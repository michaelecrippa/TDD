namespace TheXUnitExample
{
    public class TestCase
    {
        public string TestName { get; set; }

        public TestCase(string testName = "")
        {
            TestName = testName;
        }

        public void Invoke()
        {
            //do some work
        }
    }
}
