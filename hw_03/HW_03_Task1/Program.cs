using System;

namespace HW_03_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter second num:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Sum is: " + sum(Convert.ToInt32(num1), Convert.ToInt32(num2)));

            Console.ReadKey();
        }

        static int sum(int num1 = 0, int num2 = 0)
        {
            return (num1 + num2);
        }
    }
}
