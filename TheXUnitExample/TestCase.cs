using TheXUnitExample.Console;

namespace TheXUnitExample
{
    public class TestCase
    {
        public string TestName { get; set; }

        public TestCase(string testName = "")
        {
            TestName = testName;
        }

        private void SetUp()
        {
            CustomConsole.Write(CustomConsole.SetUp);
        }

        private void TearDown()
        {
            CustomConsole.Write(CustomConsole.TearDown);
        }

        private void Invoke()
        {
            CustomConsole.Write(CustomConsole.Run);
        }

        public TestResult Run()
        {
            var result = new TestResult();
            result.TestStarted();
            try
            {
                SetUp();
                Invoke();
            }
            catch (Exception)
            {
                result.TestFailed();
            }
            TearDown();

            return result;
        }
    }
}
