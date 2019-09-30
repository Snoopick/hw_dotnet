using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSum = 1000;
            int monthCount = 12;
            int resultSum = startSum;
            int monthSum = 0;

            for (int i = 1; i <= monthCount; i++)
            {
                monthSum = resultSum * 2 / 100;

                if (i < 11)
                {
                    Console.WriteLine("At " + i + " month sum will be more at " + monthSum);
                }

                resultSum += monthSum;


                if (i > 3)
                {
                    Console.WriteLine("The sum on " + i + " month will be at " + resultSum);
                }
            }
        }
    }
}
