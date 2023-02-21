using System;
namespace Variable
{
    class ArrayDemo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Random random = new Random();
            for(var i = 0; i < size; i++){
                numbers[i] = random.Next(23, 57);
            }

            foreach(int number in numbers){
                Console.WriteLine(number);
            }   
        }
    }
}