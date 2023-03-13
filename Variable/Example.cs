using System;

namespace Variable
{
    class Example
    {
        // public static void Main(string[] args)
        // {
        //     int[] numbers = new int[0];
        //     int number = 0;
        //     int i = 0;
        //     do
        //     {
        //         Console.Write($"Enter number[{i}]:");
        //         int.TryParse(Console.ReadLine(), out number);
        //         if (number != 0)
        //         {
        //             Array.Resize(ref numbers, numbers.Length + 1);
        //             numbers[numbers.Length - 1] = number;
        //             i++;
        //         }

        //     }
        //     while (number != 0);

        //     for (int k = 0; k < numbers.Length; k++)
        //     {
        //         Console.WriteLine(numbers[k]);
        //     }
        // }
        static int tableWidth = 73;

        static void Main(string[] args)
        {
            Console.Clear();
            PrintLine();
            PrintRow("Column 1", "Column 2", "Column 3", "Column 4");
            PrintLine();
            PrintRow("CodeGym Hue", "", "", "");
            PrintLine();
            PrintRow("CodeGym Viet Nam Viet Nam", "", "", "");
            PrintLine();
            Console.ReadLine();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}