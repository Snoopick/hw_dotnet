using System;
using System.Collections.Generic;
using System.Text;

namespace Task1 {
    public class Bot {

        public string Ask(string question) {
            if (question.Equals("")) {
                Console.WriteLine("Oops, something went wrong");
                return "";
            }

            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public bool AskBool(string question) {
            if (question.Equals("")) {
                Console.WriteLine("Oops, something went wrong");
                return false;
            }

            Console.WriteLine(question + " (да Y, нет N)");
            string answer = Console.ReadLine();
            bool bollAnswer = false;

            // можно через приведение к нижнему ригестру
            switch (answer) {
                case "да":
                case "Да":
                case "yes":
                case "Yes":
                case "Y":
                case "y":
                    bollAnswer = true;
                    break;
                case "Нет":
                case "нет":
                case "No":
                case "no":
                case "N":
                case "n":
                    bollAnswer = false;
                    break;
                default:
                    bollAnswer = false;
                    break;
            }

            return bollAnswer;

        }

        public void Say(string @string) {
            Console.WriteLine(@string);
        }
    }
}
