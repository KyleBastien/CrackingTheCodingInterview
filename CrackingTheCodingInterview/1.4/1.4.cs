using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class OneDotFour
    {
        public static void Main(string[] args)
        {
            // Palindrome Permutations: Given a string, write a function to check if it is a permutation of a palindrome. A palindrome is a word or phrase
            // that is the same forwards and backwards. A permutation is a rearrangement of letters. The palindrome does nto need to be limited to just dictionary words.

            Console.WriteLine(IsPermuationOfPalindrome("Tact Coa"));
            Console.WriteLine(IsPermuationOfPalindrome("racc rae"));
            Console.WriteLine(IsPermuationOfPalindrome("bobs your uncle"));
            Console.ReadLine();
        }

        // O(n) time, O(n) space
        public static bool IsPermuationOfPalindrome(string phrase)
        {
            Dictionary<char, int> phraseLetters = new Dictionary<char, int>();
            foreach(char c in phrase.ToCharArray())
            {
                if (c == ' ')
                    continue;
                else if (phraseLetters.ContainsKey(char.ToLower(c)) == false)
                    phraseLetters.Add(char.ToLower(c), 1);
                else
                    phraseLetters[char.ToLower(c)] += 1;
            }
            bool IsOdd = (phrase.Length % 2 == 0);
            bool ViewedOdd = false;
            foreach(char c in phraseLetters.Keys)
            {
                if (phraseLetters[c] % 2 != 0 && IsOdd == false)
                    return false;
                else if (phraseLetters[c] % 2 != 0 && IsOdd == true && ViewedOdd == true)
                    return false;
                else if (phraseLetters[c] % 2 != 0 && IsOdd == true && ViewedOdd == false)
                    ViewedOdd = true;
                else if (phraseLetters[c] % 2 == 0)
                    continue;
            }
            return true;
        }
    }
}
