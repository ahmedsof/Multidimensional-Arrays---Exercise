using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];
            FillMatrix(matrix);
            int counteReplaced = 0;
            int rowKiller = 0;
            int colKiller = 0;
            
            while (true)
            {
                int maxAttaks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char curentSymbol = matrix[row, col];
                        int countAttak = 0;

                        if (curentSymbol == 'K')
                        {
                            if (isInside(matrix, row - 2,col + 1) 
                            && matrix[row - 2, col + 1] == 'K')
                            {
                                
                                    countAttak++;

                            }

                            if (isInside(matrix, row - 2, col - 1)
                                && matrix[row - 2, col - 1] == 'K')
                            {

                                countAttak++;

                            }
                            if (isInside(matrix, row + 1, col + 2)
                                && matrix[row + 1, col + 2] == 'K')
                            {

                                countAttak++;

                            }

                            if (isInside(matrix, row+ 1, col -2)
                                && matrix[row + 1, col - 2] == 'K')
                            {

                                countAttak++;

                            }

                            if (isInside(matrix, row - 1, col + 2)
                                && matrix[row - 1, col + 2] == 'K')
                            {

                                countAttak++;

                            }
                            if (isInside(matrix, row - 1, col -2)
                                && matrix[row - 1, col -2] == 'K')
                            {

                                countAttak++;

                            }
                            if (isInside(matrix, row + 2, col -1)
                                && matrix[row + 2, col - 1] == 'K')
                            {

                                countAttak++;

                            }
                            if (isInside(matrix, row + 2, col + 1)
                                && matrix[row + 2, col + 1] == 'K')
                            {

                                countAttak++;

                            }

                            if (countAttak > maxAttaks)
                            {
                                maxAttaks = countAttak;
                                rowKiller = row;
                                colKiller = col;

                            }

                        }
                    }
                }

                if (maxAttaks > 0)
                {
                    matrix[rowKiller,colKiller] = '0';
                    counteReplaced++;

                }

                else
                {
                    Console.WriteLine(counteReplaced);
                    break;
                }
            }
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                   
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static bool isInside(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                                  && targetCol >= 0 && targetCol < matrix.GetLength(1);


        }
    }
}
