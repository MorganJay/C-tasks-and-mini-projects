using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string drink = "";
            Console.Write("Hi! Welcome to Morgan's Bar. How old are you? ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.Write("Have a seat! What would you like to drink? ");
                drink = Console.ReadLine();                
            }
            else if(age <= 12)
            {
                Console.WriteLine("You're too young to drink, let's call your parents to come pick you up.");
            }
            else
            {
                Console.WriteLine("You're too young to drink, please leave.");
            }
        }
    }
}
