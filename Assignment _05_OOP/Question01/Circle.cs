using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__05_OOP.Question01
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius =radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"[Circle] Radius = {Radius}, Area = {Area:F2}");
        }
    }
}
