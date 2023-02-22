using System;
namespace Method
{
    class CreateArray
    {
        public static void Main(string[] args)
        {
            int[] numbers = GenerateArray();
            PrintArray(numbers);
        }   

        public static int[] GenerateArray()
        {
            int[] numbers = new int[0];
            int i = 0;
            int number = 0;
            bool result = true;

            do
            {
                do
                {
                    Console.Write($"Enter number {i}: ");
                    result = int.TryParse(Console.ReadLine(), out number);
                }
                while (!result);
                if (number != 0)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number;
                    i++;
                }

            }
            while (number != 0);

            return numbers;
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0 ; i < array.Length; i++){
                Console.WriteLine(array[i]);
            }
        }
    }
}