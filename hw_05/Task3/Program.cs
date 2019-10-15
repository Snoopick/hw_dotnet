using System;

namespace Task3 {
    class Program {
        static void Main(string[] args) {
            int arraySize = 5;
            int[] array = new int[arraySize];
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < arraySize; i++) {
                Console.WriteLine("Enter num:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before:");
            Console.WriteLine(string.Join(", ", array));

            for (int i = 0; i < arraySize; i++) {
                int j = arraySize - 1 - i;

                if (i >= j) {
                    break;
                }

                index1 = array[i];
                index2 = array[j];
                array[i] = index2;
                array[j] = index1;
            }

            Console.WriteLine("Array after:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
