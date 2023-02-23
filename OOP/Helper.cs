using System;

namespace OOP
{
    static class Helper
    {
        public static double PI = 3.14;

        public static double GetArea(double width, double height)
        {
            return width * height;
        }

        public static string Alert(string message)
        {
            return $"[Info] {message}!";
        }
    }
}