using System;

namespace Variable
{
    class NestedArray
    {
        public static void Main(string[] agrs)
        {
            int[][] matrix = new int[3][] {
                new int[] { 1,2,3,4},
                new int[] { 1,2,3},
                new int[] { 1,2}
            };

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}