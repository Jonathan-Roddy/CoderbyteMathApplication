using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    // Parent class
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Perimeter { get; }

        public abstract double SurfaceArea { get; }

        public static int Instance;

        public static double GetArea(Shape shape) => shape.SurfaceArea;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;

        public static void PrintShape(List<Shape> shape) {
            int i = 1;
            foreach (var s in shape) { 

                Console.WriteLine(i + ") " + $"{s.Name}: Area = {Shape.GetArea(s)}; " + $"Perimeter = {Shape.GetPerimeter(s)};");
                i++;
            }
        }
    }
}
