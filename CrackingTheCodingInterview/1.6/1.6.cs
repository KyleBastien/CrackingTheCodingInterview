using System;

namespace CrackingTheCodingInterview
{
    public class OneDotSix
    {
        public static void Main(string[] args)
        {
            // 1.6: String Compression: Implement a method to perform basic string compression using the counts of repeated characters. For example, the string
            // aabcccccaaa would become a2b1c5a3. If the "compressed" string would not become smaller than the original string, your method should return the
            // original string. You can assume the string has only uppercase and lowercase letters (a-z).

            Console.WriteLine(basicStringCompression("aabcccccaaa"));
            Console.ReadLine();
        }

        public static string basicStringCompression(string input)
        {
            string shortString = "";
            char currentChar = ' ';
            int countOfChar = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (currentChar == ' ')
                {
                    currentChar = input[i];
                    countOfChar++;
                }
                else if (currentChar == input[i])
                {
                    countOfChar++;
                }
                else if (currentChar != input[i])
                {
                    shortString += "" + currentChar + countOfChar;
                    currentChar = input[i];
                    countOfChar = 1;
                }
            }
            shortString += "" + currentChar + countOfChar;
            if (input.Length <= shortString.Length)
                return input;
            else
                return shortString;
        }
    }
}
