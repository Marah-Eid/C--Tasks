using System;

namespace InterfaceException
{
    interface ICalculator
    {
        int Add(int a, int b);
    }

    class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine()!);

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine()!);

                ICalculator calc = new Calculator();
                int result = calc.Add(num1, num2);

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }
        }
    }
}
