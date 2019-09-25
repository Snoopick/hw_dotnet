using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("");
            byte byte1 = 1;
            Byte byte2 = 2;

            Console.WriteLine("byte byte1 " + byte1.GetType());
            Console.WriteLine("Byte byte2 " + byte2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            sbyte sbyte1 = 1;
            SByte sbyte2 = 2;

            Console.WriteLine("sbyte sbyte1 " + sbyte1.GetType());
            Console.WriteLine("SByte sbyte2 " + sbyte2.GetType());
            Console.WriteLine("__________________________________________");

            
            Console.WriteLine("");
            short short1 = 1;
            Int16 short2 = 2;

            Console.WriteLine("short short1 " + short1.GetType());
            Console.WriteLine("Int16 short2 " + short2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            ushort ushort1 = 1;
            UInt16 ushort2 = 2;

            Console.WriteLine("ushort ushort1 " + ushort1.GetType());
            Console.WriteLine("UInt16 ushort2 " + ushort2.GetType());
            Console.WriteLine("__________________________________________");


            int int1 = 1;
            Int32 int2 = 2; 

            Console.WriteLine("int int1 " + int1.GetType());
            Console.WriteLine("Int32 int2 " + int2.GetType());
            Console.WriteLine("__________________________________________");


            uint uint1 = 1;
            UInt32 uint2 = 2;

            Console.WriteLine("int uint1 " + uint1.GetType());
            Console.WriteLine("Int32 uint2 " + uint2.GetType());
            Console.WriteLine("__________________________________________");

            
            Console.WriteLine("");
            long long1 = 1;
            Int64 long2 = 2;

            Console.WriteLine("long long1 " + long1.GetType());
            Console.WriteLine("Int64 long2 " + long2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            ulong ulong1 = 1;
            UInt64 ulong2 = 2;

            Console.WriteLine("ulong ulong1 " + ulong1.GetType());
            Console.WriteLine("UInt64 ulong2 " + ulong2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            float float1 = 1.2f;
            Single float2 = 2.2f;

            Console.WriteLine("float float1 " + float1.GetType());
            Console.WriteLine("Single float2 " + float2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            double double1 = 1.2;
            Double double2 = 2.2;

            Console.WriteLine("double double1 " + double1.GetType());
            Console.WriteLine("Double double2 " + double2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            char char1 = '1';
            Char char2 = '2';

            Console.WriteLine("char char1 " + char1.GetType());
            Console.WriteLine("Char char2 " + char2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            bool bool1 = true;
            Boolean bool2 = false;

            Console.WriteLine("bool bool1 " + bool1.GetType());
            Console.WriteLine("Boolean bool2 " + bool2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            decimal decimal1 = 1;
            Decimal decimal2 = 2;

            Console.WriteLine("decimal decimal1 " + decimal1.GetType());
            Console.WriteLine("Decimal decimal2 " + decimal2.GetType());
            Console.WriteLine("__________________________________________");


            Console.WriteLine("");
            object object1 = 1;
            Object object2 = 2;

            Console.WriteLine("object object1 " + object1.GetType());
            Console.WriteLine("Object object2 " + object2.GetType());
            Console.WriteLine("__________________________________________");



            Console.WriteLine("");
            string string1 = "1";
            String string2 = "2";

            Console.WriteLine("string string1 " + string1.GetType());
            Console.WriteLine("String string2 " + string2.GetType());
            Console.WriteLine("__________________________________________");


            Console.ReadKey();
        }
    }
}
