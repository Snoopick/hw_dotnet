using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //явное преобразование типов
            double doubleValue = 1234.7;
            int intValue = (int)doubleValue;

            Console.WriteLine("Explicit type conversion 1:");
            Console.WriteLine("double doubleValue = 1234.7, int intValue = (int)doubleValue;");
            Console.WriteLine("Result is: " + intValue);
            Console.WriteLine("__________________________________________");


            byte byteValue = 2;
            sbyte sbyteValue = (sbyte)byteValue;

            Console.WriteLine("Explicit type conversion 2:");
            Console.WriteLine("byte byteValue = 2, char sbyteValue = (sbyte)byteValue;");
            Console.WriteLine("Result is: " + sbyteValue);
            Console.WriteLine("__________________________________________");


            short shortValue = 45;
            byte byteValue2 = (byte)shortValue;

            Console.WriteLine("Explicit type conversion 3:");
            Console.WriteLine("short shortValue = 45, byte byteValue2 = (byte)shortValue;");
            Console.WriteLine("Result is: " + byteValue2);
            Console.WriteLine("__________________________________________");


            //неявное преобразование типов
            Console.WriteLine("");

            byte byteValue3 = 4;
            int intValue3 = byteValue3 + 20;

            Console.WriteLine("Implicit type conversion 1:");
            Console.WriteLine("byte byteValue3 = 4, int intValue3 = byteValue3 + 20;");
            Console.WriteLine("Result is: " + intValue3);
            Console.WriteLine("__________________________________________");

            int intValue4 = 0123456789;
            long longValue4 = intValue4;

            Console.WriteLine("Implicit type conversion 2:");
            Console.WriteLine("int intValue4 = 0123456789, long longValue4 = intValue4;");
            Console.WriteLine("Result is: " + longValue4);
            Console.WriteLine("__________________________________________");


            long e2 = 10;
            double f2 = e2 + 4.5;

            Console.WriteLine("Implicit type conversion 3:");
            Console.WriteLine("long e2 = 10, double f2 = e2 + 4.5;");
            Console.WriteLine("Result is: " + f2);
            Console.WriteLine("__________________________________________");


            //boxing
            Console.WriteLine("");

            int intValue5 = 123;
            object objectValue5 = intValue5;

            Console.WriteLine("Boxing:");
            Console.WriteLine("int intValue5 = 123, object objectValue5 = intValue5;");
            Console.WriteLine("Result is: " + objectValue5);
            Console.WriteLine("__________________________________________");


            //unboxing
            Console.WriteLine("");

            object objectValue6 = 123;
            int intValue6 = (int)objectValue6;

            Console.WriteLine("Unboxing:");
            Console.WriteLine("object objectValue6 = 123, int intValue6 = (int)objectValue6;");
            Console.WriteLine("Result is: " + intValue6);
            Console.WriteLine("__________________________________________");


            Console.ReadKey();
        }
    }
}
