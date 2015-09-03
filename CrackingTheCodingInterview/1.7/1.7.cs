using System;

namespace CrackingTheCodingInterview
{
    public class OneDotSeven
    {
        public static void Main(string[] args)
        {
            // 1.7: Rotate Matrix: Given an image represented by an NxN matrix, where each pixes in the image is 4 bytes, write a method to rotte the image by
            // 90 degrees. Can you do this in place?

            // So i'm not sure what this question is asking exactly...especially the bit about the 4 bytes, but I'm going to just write a standard NxN matrix 
            // 90 degree rotation.

            int[][] input = new int[5][];
            input[0] = new int[] { 1, 2, 3, 4, 5};
            input[1] = new int[] { 6, 7, 8, 9, 10 };
            input[2] = new int[] { 11, 12, 13, 14, 15 };
            input[3] = new int[] { 16, 17, 18, 19, 20 };
            input[4] = new int[] { 21, 22, 23, 24, 25 };

            Console.WriteLine("Original Matrix: ");
            prettyPrintNxNMatrix(input);

            Console.WriteLine("\n\nNew Matrix: ");
            prettyPrintNxNMatrix(rotateMatrix90Degree(input));
            Console.ReadLine();
        }

        public static int[][] rotateMatrix90Degree(int[][] input)
        {
            int n = input.Length;

            for(int layer = 0; layer < n / 2; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;
                for(int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    // save top
                    int top = input[first][i];

                    //left -> top
                    input[first][i] = input[last - offset][first];

                    //bottom -> left
                    input[last - offset][first] = input[last][last - offset];

                    //right -> bottom
                    input[last][last - offset] = input[i][last];

                    //top -> right
                    input[i][last] = top;
                }
            }

            return input;
        }

        public static void prettyPrintNxNMatrix(int[][] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input[0].Length; j++)
                {
                    if (j == 0)
                        Console.Write("[ " + input[i][j] + ", ");
                    else if (j != input[0].Length - 1)
                        Console.Write(input[i][j] + ", ");
                    else
                        Console.WriteLine(input[i][j] + " ]");
                }
            }
        }
    }
}
