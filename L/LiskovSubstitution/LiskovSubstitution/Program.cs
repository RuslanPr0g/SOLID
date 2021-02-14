using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            TestRectangleArea(rect);

            Console.Read();
        }

        public static void TestRectangleArea(Rectangle rect)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
                throw new Exception("Wrong area!");
        }
    }
}
