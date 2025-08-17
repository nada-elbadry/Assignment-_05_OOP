using Assignment__05_OOP.Question01;

namespace Assignment__05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test Question 01
            Console.WriteLine("=== Q1: Shapes ===");
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            Console.WriteLine();
            #endregion
        }
    }
}
