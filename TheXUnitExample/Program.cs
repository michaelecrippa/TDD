using TheXUnitExample;

class Prgram 
{
    static void Main()
    {
        var testCase = new TestCaseTest();

        testCase.IsTestSetUp();
        testCase.IsTestRun();
        testCase.IsTestTearDown();
    }
}

