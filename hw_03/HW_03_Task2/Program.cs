using System;

namespace HW_03_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter second num:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter sum as you think:");
            string sum = Console.ReadLine();

            int rightSum = sumFunction(Convert.ToInt32(num1), Convert.ToInt32(num2));

            if (Convert.ToInt32(sum) == rightSum)
            {
                Console.WriteLine("You right");
            }
            else
            {
                Console.WriteLine("You are fault");
            }

            

            Console.ReadKey();
        }

        static int sumFunction(int num1 = 0, int num2 = 0)
        {
            return (num1 + num2);
        }
    }
}
