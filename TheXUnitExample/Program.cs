using TheXUnitExample;

class Program 
{
    static void Main()
    {
        var suite = new TestSuite();
        suite.Add(new TestCaseTest("testTemplateMethod"));
        suite.Add(new TestCaseTest("testResult"));
        suite.Add(new TestCaseTest("testFailedResultFormatting"));
        suite.Add(new TestCaseTest("testFailedResult"));
        suite.Add(new TestCaseTest("testSuite"));
        var result = suite.Run();
        Console.WriteLine(result.Summary);
    }
}

