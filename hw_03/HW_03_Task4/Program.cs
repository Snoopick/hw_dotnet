using System;

namespace HW_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num:");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter second num:");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter operator:");
            string needOperator = Console.ReadLine();

            Console.WriteLine("Enter result as you think:");
            string result = Console.ReadLine();

            int rightSum = sumFunction(Convert.ToInt32(num1), Convert.ToInt32(num2), needOperator);

            int userSum = Convert.ToInt32(result);

            if (userSum == rightSum)
            {
                Console.WriteLine("You right");
            }
            else if (userSum > rightSum)
            {
                Console.WriteLine("You are fault,\n" +
                    "Sum must be less");
            }
            else if (userSum < rightSum)
            {
                Console.WriteLine("You are fault,\n" +
                    "Sum must be more");
            }

            Console.ReadKey();
        }

        static int sumFunction(int num1 = 0, int num2 = 0, string needOperator = "")
        {
            int operationResult = 0;

            if (needOperator == "+")
            {
                operationResult = (num1 + num2);
            }
            else if (needOperator == "-")
            {
                operationResult = (num1 - num2);
            }

            return operationResult;
        }
    }
}
