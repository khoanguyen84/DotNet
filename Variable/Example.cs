using System;

namespace Variable
{
    class Example
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[0];
            int number = 0;
            int i = 0;
            do
            {
                Console.Write($"Enter number[{i}]:");
                int.TryParse(Console.ReadLine(), out number);
                if (number != 0)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number;
                    i++;
                }

            }
            while (number != 0);

            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine(numbers[k]);
            }
        }
    }
}