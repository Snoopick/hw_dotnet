using System;

namespace HW_03_Task3
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

            int userSum = Convert.ToInt32(sum);

            if (userSum == rightSum)
            {
                Console.WriteLine("You right");
            }
            else if(userSum > rightSum) 
            {
                Console.WriteLine("You are fault,\n" +
                    "Sum must be less");
            } else if (userSum < rightSum)
            {
                Console.WriteLine("You are fault,\n" +
                    "Sum must be more");    
            }

            Console.ReadKey();
        }

        static int sumFunction(int num1 = 0, int num2 = 0)
        {
            return (num1 + num2);
        }
    }
}
