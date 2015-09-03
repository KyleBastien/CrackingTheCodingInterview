using System;

namespace CrackingTheCodingInterview
{
    public class OneDotNine
    {
        public static void Main(string[] args)
        {
            // 1.9: String Rotation: Assume you have a method IsSubstring which check if one word is a substring of another. Given two strings, s1 and s2, write
            // code to check if s2 is a rotation of s1 using only one call to isSubstring (e.g., "waterbottle" is a rotation of "erbottlewat").
            Console.WriteLine(IsRotation("waterbottle", "erbottlewat"));
            Console.ReadLine();
        }

        public static bool IsRotation(string s1, string s2)
        {
            int length = s1.Length;
            if(length == s2.Length && length > 0)
            {
                string s1s1 = s1 + s1;
                return isSubstring(s1s1, s2);
            }
            return false;
        }

        public static bool isSubstring(string s1, string s2)
        {
            return s1.ToLower().Contains(s2.ToLower());
        }
    }
}
