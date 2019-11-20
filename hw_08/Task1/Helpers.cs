using System;
using System.Collections.Generic;
using System.Text;

namespace Task1 {
    public class Helpers {

        public int GetrandomNum(int min, int max) {
            Random random = new Random();

            return random.Next(min, max);
        }

        public void Wait() {
            Console.ReadLine();
        }
    }
}
