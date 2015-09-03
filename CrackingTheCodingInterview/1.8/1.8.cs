using System;

namespace CrackingTheCodingInterview
{
    public class OneDotEight
    {
        public static void Main(string[] args)
        {
            // Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.

            int[][] input = new int[5][];
            input[0] = new int[] { 1, 2, 3, 4, 5 };
            input[1] = new int[] { 6, 7, 0, 9, 10 };
            input[2] = new int[] { 0, 12, 13, 14, 15 };
            input[3] = new int[] { 16, 17, 18, 19, 20 };
            input[4] = new int[] { 21, 22, 23, 24, 0 };

            Console.WriteLine("Original Matrix: ");
            prettyPrintMatrix(input);

            Console.WriteLine("\n\nNew Matrix: ");
            prettyPrintMatrix(zeroMatrix(input));
            Console.ReadLine();
        }

        public static int[][] zeroMatrix(int[][] input)
        {
            bool[] rowsToZero = new bool[input.Length];
            bool[] columnsToZero = new bool[input[0].Length];

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input[i].Length; j++)
                {
                    if(input[i][j] == 0)
                    {
                        rowsToZero[i] = true;
                        columnsToZero[j] = true;
                    }
                }
            }

            for(int i = 0; i < rowsToZero.Length; i++)
            {
                if(rowsToZero[i]) { nullifyRow(input, i); }
            }

            for(int j = 0; j < columnsToZero.Length; j++)
            {
                if(columnsToZero[j]) { nullifyColumn(input, j); }
            }

            return input;
        }

        public static void nullifyRow(int[][] input, int row)
        {
            for(int j = 0; j < input[0].Length; j++)
            {
                input[row][j] = 0;
            }
        }

        public static void nullifyColumn(int[][] input, int column)
        {
            for(int i = 0; i < input.Length; i++)
            {
                input[i][column] = 0;
            }
        }

        public static void prettyPrintMatrix(int[][] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
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
