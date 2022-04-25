namespace TheXUnitExample.Console
{
    public static class CustomConsole
    {
        public const string SetUp = "SetUp";

        public const string Run = "Run";

        public const string TearDown = "TearDown";

        private static string _text = "";

        public static void Write(string input)
        {
            System.Console.WriteLine(input);
            _text += input;
        }

        public static bool Contains(string input)
        {
           return _text.Contains(input);
        }
    }
}
