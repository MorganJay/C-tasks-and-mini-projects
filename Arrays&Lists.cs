using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysandLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] accountBalances = new int[5];

            accountBalances[0] = 10000;
            accountBalances[1] = 50000;
            accountBalances[2] = 500;
            accountBalances[3] = 100;
            accountBalances[4] = 5000;

            int sum = accountBalances.Sum();
            Console.WriteLine(sum);

            List<string> fruits =  new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Pineapple");
            fruits.Add("Pear");

            //Console.WriteLine(fruits[2]);
        }
    }
}
