using System;

namespace Variable
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine($"The number is {number}");
            // Console.WriteLine(String.Format("The number is {0}, name is {1}", number, "ten"));
            // for(byte i = 0; i < number; i++){
            //     Console.WriteLine(i);
            // }

            // byte i = 0;
            // while(i < number){
            //     Console.WriteLine(i);
            //     i++;
            // }

            byte i = 0;
            do {
                Console.WriteLine(i);
                i++;
            }
            while(i < number);
        }
    }
}