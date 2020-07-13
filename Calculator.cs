using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,number2;
            int result = 0;
            string symbol = "";
            Console.WriteLine("Welcome to the General Arithmetic Calculator\n");

            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter an operation symbol, (+ or / or - or *): ");
            symbol = Console.ReadLine();

            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            if (symbol == "+")
            {
                result = number1 + number2;
            }
            else if (symbol == "/")
            {
                result = number1/number2;
            }
            else if (symbol == "*")
            {
                result = number1*number2;
            }
            else if (symbol == "-")
            {
                result = number1 - number2;
            }
            Console.WriteLine("The result is " + result);
            Console.Read();
        }
    }
}
