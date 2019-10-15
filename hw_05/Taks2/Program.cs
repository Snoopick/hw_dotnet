using System;

namespace Taks2 {
    class Program {
        static void Main(string[] args) {
            int arraySize = 10;
            int[] array = new int[arraySize];
            int num = 0;
            int position = -1;

            for (int i = 0; i < (arraySize - 1); i++) {
                Console.WriteLine("Enter num:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered array:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("Enter one more num:");
            num = Convert.ToInt32(Console.ReadLine());

            while (position < 0 || position > (arraySize - 1)) {
                Console.WriteLine("Enter position in array, from 0 to " + (arraySize - 1) + ":");
                position = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = (arraySize - 1); i > position; i--) {
                array[i] = array[i - 1];
            }

            array[position] = num;

            Console.WriteLine("Result array:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
