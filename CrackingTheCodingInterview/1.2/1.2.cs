using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1.2 : Check Permutation: Give two strings, write a method to decide if one is a premutation of the other.

            Console.WriteLine(IsPermutation(null, null));
            Console.WriteLine(IsPermutation("a", "a"));
            Console.WriteLine(IsPermutation("ab", "ba"));
            Console.WriteLine(IsPermutation("ab", "bc"));
            Console.WriteLine(IsPermutation("abc", "cba"));
            Console.WriteLine(IsPermutation("abcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcba"));
            Console.ReadLine();
        }

        public static bool IsPermutation(string a, string b)
        {
            if(a == null || b == null)
            {
                return false;
            }
            if(a.Equals(b))
            {
                return true;
            }
            Dictionary<char, int> charsInStringA = new Dictionary<char, int>();
            foreach(char c in a.ToCharArray())
            {
                if(charsInStringA.ContainsKey(c) == false)
                {
                    charsInStringA.Add(c, 1);
                }
                else
                {
                    charsInStringA[c] += 1;
                }
            }

            foreach(char c in b.ToCharArray())
            {
                if(charsInStringA.ContainsKey(c) == false)
                {
                    return false;
                }
                else
                {
                    charsInStringA[c] -= 1;
                    if(charsInStringA[c] < 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
