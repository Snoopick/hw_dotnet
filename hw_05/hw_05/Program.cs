using System;

namespace hw_05 {
    class Program {
        static void Main(string[] args) {
            int arraySize = 10;
            int[] firstArray = new int[arraySize];
            int[] secondArray = new int[arraySize];
            int[] rerultArray = new int[arraySize];
            Random rand = new Random();

            for (int i = 0; i < arraySize; i++) {
                firstArray[i] = rand.Next(1, 100);
            }

            for (int i = 0; i < arraySize; i++) {
                Console.WriteLine("Enter num:");
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arraySize; i++) {
                rerultArray[i] = firstArray[i] + secondArray[i];
            }

            Console.WriteLine("First array:");
            Console.WriteLine(string.Join(", ", firstArray));

            Console.WriteLine("Second array:");
            Console.WriteLine(string.Join(", ", secondArray));

            Console.WriteLine("Result array:");
            Console.WriteLine(string.Join(", ", rerultArray));
        }
    }
}
