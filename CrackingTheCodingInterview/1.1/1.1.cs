using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class OneDotOne
    {
        public static void Main(string[] args)
        {
            // 1.1: Is Unique: Implement an algorithm to determine if a string has all unique charactrs. WHat if you cannot use additional data structures?

            // I'm not sure how to approach this without using another data structure, I know it has to do with a Bit Map, but I'm not looking at the solutions
            // so I really don't know, therefore I'm posting my first solution.
            Console.WriteLine(IsStringCharactersUnique(""));
            Console.WriteLine(IsStringCharactersUnique("a"));
            Console.WriteLine(IsStringCharactersUnique("aa"));
            Console.WriteLine(IsStringCharactersUnique("ab"));
            Console.WriteLine(IsStringCharactersUnique("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(IsStringCharactersUnique("abcabc"));
            Console.WriteLine(IsStringCharactersUnique("aabb"));
            Console.WriteLine(IsStringCharactersUnique(null));
            Console.ReadLine();
        }

        public static bool IsStringCharactersUnique(string input)
        {
            if (input == null)
            {
                return false;
            }
            if (input.Length <= 1)
            {
                return true;
            }
            Dictionary<char, int> charsInString = new Dictionary<char, int>();
            foreach(char c in input.ToCharArray())
            {
                if(charsInString.ContainsKey(c) == false)
                {
                    charsInString.Add(c, 1);
                }
                else
                {
                    charsInString[c] += 1;
                }
            }
            foreach(char c in charsInString.Keys)
            {
                if (charsInString[c] > 1)
                    return false;
            }
            return true;
        }
    }
}
