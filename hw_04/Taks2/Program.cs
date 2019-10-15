using System;

namespace Taks2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter char(w, a, s, d),\n" +
                "for close console enter 'exit'") ;
                string enterChar = Console.ReadLine();

                if (enterChar != "exit") {
                    switch (enterChar)
                    {
                        case "w":
                        case "W":
                            Console.WriteLine("Go up\n");
                            break;
                        case "a":
                        case "A":
                            Console.WriteLine("Go left\n");
                            break;
                        case "s":
                        case "S":
                            Console.WriteLine("Go down\n");
                            break;
                        case "d":
                        case "D":
                            Console.WriteLine("Go right\n");
                            break;
                        default:
                            Console.WriteLine("You are entered wrong char, I dont know what to do! \n");
                            break;
                    }
                }
                else
                {
                    flag = false;
                }
            }
        }
    }
}
