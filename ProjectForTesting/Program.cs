using System;

namespace ProjectForTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = 5;
            var b = 4;

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(a, b));
            Console.WriteLine(calculator.Subtract(a, b));
            Console.WriteLine(calculator.Multiply(a, b));
            Console.WriteLine(calculator.Divide(a, b));
        }
    }
}