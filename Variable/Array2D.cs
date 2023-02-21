using System;

namespace Variable
{
    class Array2D
    {
        public static void Main(string[] agrs)
        {
            int[,] matrix = new int[3, 3] {
                {4,5,6},
                {4,5,6},
                {4,5,6}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}