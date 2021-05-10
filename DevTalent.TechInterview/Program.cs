using System;

namespace DevTalent.TechInterview
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Execute("Hello World"));
        }

        public static string Execute(string input)
        {
            return input != null ? input.ToUpper() : string.Empty;
        }
    }
}
