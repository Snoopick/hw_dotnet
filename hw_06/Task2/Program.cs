using System;
using System.Linq;

namespace Task2 {
    class Program {
        static void Main(string[] args) {
            string str = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";

            Console.WriteLine("String: " + str);

            RemoveLongestWord(str);
            WordReplacing(str);
            getCounChar(str);
            sortingStringArray(str);
        }

        static void RemoveLongestWord(string str) {
            String[] wordArray = str.Split(" ");
            string longestWord = "";
            int longestWordIndex = 0;
            string resultStr = "";

            for (int i = 0; i < wordArray.Length; i++) {
                if (wordArray[i].Length > longestWord.Length) {
                    longestWord = wordArray[i];
                    longestWordIndex = i;
                }
            }

            for (int i = 0; i < wordArray.Length; i++) {
                if (i != longestWordIndex) {
                    resultStr += wordArray[i] + " ";
                }
            }

            Console.WriteLine("Longest word is: " + longestWord);
            Console.WriteLine("Result is \n" + resultStr);
        }

        static void WordReplacing (string str) {
            String[] wordArray = str.Split(" ");
            string longestWord = "";
            string shortWord = "";
            int longestWordIndex = 0;
            int shortWordIndex = 0;
            string resultStr = "";

            for (int i = 0; i < wordArray.Length; i++) {
                if (shortWord.Equals("")) {
                    shortWord = wordArray[i];
                }

                if (wordArray[i].Length > longestWord.Length) {
                    longestWord = wordArray[i];
                    longestWordIndex = i;
                }

                if (wordArray[i].Length < shortWord.Length) {
                    shortWord = wordArray[i];
                    shortWordIndex = i;
                }
            }

            for (int i = 0; i < wordArray.Length; i++) {
                if (i == longestWordIndex) {
                    resultStr += wordArray[shortWordIndex] + " ";
                } else if (i == shortWordIndex) {
                    resultStr += wordArray[longestWordIndex] + " ";
                } else {
                    resultStr += wordArray[i] + " ";
                }
            }

            Console.WriteLine("Longest word is: " + longestWord);
            Console.WriteLine("Short word is: " + shortWord);
            Console.WriteLine("Result is \n" + resultStr);
        }

        static void getCounChar(string str) {
            Char[] pChars = new char[6] { '.', ',', ':', ';', '!', '?' };
            int pCharsCounter = 0;
            int spaceCounter = 0;

            for (int i = 0; i < str.Length; i++) {
                if (pChars.Contains(str[i])) {
                    pCharsCounter++;
                } else if (str[i] == ' ') {
                    spaceCounter++;
                }
            }

            Console.WriteLine("Chars count : " + (str.Length - pCharsCounter - spaceCounter));
            Console.WriteLine("Punctuation chars count : " + pCharsCounter);
        }

        static void sortingStringArray(string str) {
            String[] wordArray = str.Split(" ");

            Array.Sort(wordArray, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Sorted string array:\n");
            Console.WriteLine(string.Join("\n", wordArray));
        }
    }
}
