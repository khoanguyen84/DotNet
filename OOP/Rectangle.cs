using System;
namespace OOP
{
    class Rectangle : Side, IShape 
    {
        public Rectangle(double width, double height) : base(width, height)
        {

        }
        public double GetArea()
        {
            return Side_1 * Side_2;
        }

        public double GetPrimeter()
        {
            return (Side_1 + Side_2) * 2;
        }
    }
}