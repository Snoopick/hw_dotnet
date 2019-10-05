using System;

namespace Task1 {
    class Program {
        static void Main(string[] args) {
            string theLine = "";

            Console.WriteLine("Write the poem, seporate line \";\" char");
            theLine = Console.ReadLine();

            String[] stringArray = theLine.Split(";");

            for (int i = 0; i < stringArray.Length; i++) {
                stringArray[i] = stringArray[i].Replace("O", "A");
            }

            Console.WriteLine(string.Join("\n\n" + new String('-', 10) + "\n\n", stringArray));
        }
    }
}
