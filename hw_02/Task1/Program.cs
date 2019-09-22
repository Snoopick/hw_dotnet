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
            double a1 = 1234.7;
            int b1 = (int)a1;

            Console.WriteLine("Explicit type conversion 1:");
            Console.WriteLine("double a1 = 1234.7, int b1 = (int)a1;");
            Console.WriteLine("Result is: " + b1);
            Console.WriteLine("__________________________________________");


            byte c1 = 2;
            sbyte d1 = (sbyte)c1;

            Console.WriteLine("Explicit type conversion 2:");
            Console.WriteLine("byte c1 = 2, char d1 = (char)c1;");
            Console.WriteLine("Result is: " + d1);
            Console.WriteLine("__________________________________________");


            short e1 = 45;
            byte f1 = (byte)e1;

            Console.WriteLine("Explicit type conversion 3:");
            Console.WriteLine("short e1 = 45, byte f1 = (byte)e1;");
            Console.WriteLine("Result is: " + f1);
            Console.WriteLine("__________________________________________");


            //неявное преобразование типов
            Console.WriteLine("");

            byte a2 = 4;
            int b2 = a2 + 20;

            Console.WriteLine("Implicit type conversion 1:");
            Console.WriteLine("byte a2 = 4, int b2 = a2 + 20;");
            Console.WriteLine("Result is: " + b2);
            Console.WriteLine("__________________________________________");

            int c2 = 0123456789;
            long d2 = c2;

            Console.WriteLine("Implicit type conversion 2:");
            Console.WriteLine("int c2 = 0123456789, long d2 = c2;");
            Console.WriteLine("Result is: " + d2);
            Console.WriteLine("__________________________________________");


            long e2 = 10;
            double f2 = e2 + 4.5;

            Console.WriteLine("Implicit type conversion 3:");
            Console.WriteLine("long e2 = 10, double f2 = e2 + 4.5;");
            Console.WriteLine("Result is: " + f2);
            Console.WriteLine("__________________________________________");


            //boxing
            Console.WriteLine("");

            int a3 = 123;
            object b3 = a3;

            Console.WriteLine("Boxing:");
            Console.WriteLine("int a3 = 123, object b3 = a3;");
            Console.WriteLine("Result is: " + b3);
            Console.WriteLine("__________________________________________");


            //unboxing
            Console.WriteLine("");

            object a4 = 123;
            int b4 = (int)a4;

            Console.WriteLine("Unboxing:");
            Console.WriteLine("object a4 = 123, int b4 = (int)a4;");
            Console.WriteLine("Result is: " + b4);
            Console.WriteLine("__________________________________________");


            Console.ReadKey();
        }
    }
}
