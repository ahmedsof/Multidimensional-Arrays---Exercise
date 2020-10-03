﻿using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows,cols];
            FillMatrix(matrix);

            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currentElemen = matrix[row,col];

                    if (currentElemen == matrix[row,col + 1] 
                    && currentElemen == matrix[row + 1,col+1]
                    && currentElemen == matrix[row +1,col])
                    {
                        count++;
                    }

                }
            }

            Console.WriteLine(count);
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
