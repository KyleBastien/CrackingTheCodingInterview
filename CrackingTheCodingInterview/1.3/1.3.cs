using System;

namespace CrackingTheCodingInterview
{
    public class OneDotThree
    {
        public static void Main(string[] args)
        {
            // 1.3: URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
            // has sufficient space at the end to hold the additional characters, and that you are given the "true"
            // length of the string. (Note: if implementing in Java, please use a character array so that you can
            // perform the operation in place.)
            char[] mrjohnsmith = { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ' };
            Console.WriteLine(URLify(mrjohnsmith, 13));
            Console.ReadLine();
        }

        public static char[] URLify(char[] stringy, int length)
        {
            for(int i = 0; i < length; i++)
            {
                if(stringy[i].Equals(' '))
                {
                    stringy = MoveTwoDownFromHere(stringy, i);
                    stringy[i] = '%';
                    stringy[i + 1] = '2';
                    stringy[i + 2] = '0';
                }
            }
            return stringy;
        }

        public static char[] MoveTwoDownFromHere(char[] stringy, int pos)
        {
            bool movingElements = false;
            for(int i = stringy.Length-1; i > pos; i--)
            {
                if (stringy[i].Equals(' ') && movingElements == false)
                    continue;
                else
                {
                    movingElements = true;
                    stringy[i + 2] = stringy[i];
                }
            }
            return stringy;
        }


    }
}
