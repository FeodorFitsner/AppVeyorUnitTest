using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string data = "abcde *.(.).";

            var result = Uri.EscapeDataString(data);

            Console.WriteLine(result);
        }
    }
}
