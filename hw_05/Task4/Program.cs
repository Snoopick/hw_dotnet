using System;
using System.Diagnostics;

namespace Task4 {
    class Program {
        static void Main(string[] args) {
            int arraySize = 100000;
            long[] originalArray = new long[arraySize];
            long[] array = new long[arraySize];
            long index1 = 0;
            long index2 = 0;
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();
            Random rand = new Random();

            for (int i = 0; i < arraySize; i++) {
                array[i] = rand.Next(1, 100);
            }

            originalArray = array;

            stopwatch2.Start();
            Array.Reverse(originalArray);
            stopwatch2.Stop();

            Console.WriteLine("Standart reverse work " + stopwatch2.Elapsed);

            stopwatch.Start();

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

            stopwatch.Stop();

            Console.WriteLine("My reverse work " + stopwatch.Elapsed);
        }
    }
}
