using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber = 0;
            int result = 0;
            
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            //Adding values entered by user, then stores value in result, then display the result.
            result = firstNumber + secondNumber;
            Console.WriteLine("The answer is " + result);
        }
    }
}
