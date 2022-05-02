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

        private void SetUp()
        {
            CustomConsole.Write(TestName + '-' + CustomConsole.SetUp);
        }

        private void TearDown()
        {
            CustomConsole.Write(TestName + '-' + CustomConsole.TearDown);
            CustomConsole.Write(string.Empty);
        }

        private void Invoke()
        {
            CustomConsole.Write(TestName + '-' + CustomConsole.Run);
        }
    }
}
