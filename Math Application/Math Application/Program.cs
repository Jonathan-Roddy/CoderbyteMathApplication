using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Math_Application
{
    class Program
    {
        static void Main()
        {
            List<Shape> ourShapes = PopulateShapes();
            Console.WriteLine(" Shapes not ordered \n");

            Shape.PrintShape(ourShapes.ToList());
            
            // Q5
            Console.WriteLine("\n Shapes ordered by Area \n");
            var orderedByArea = ourShapes.OrderBy(o => o.SurfaceArea).ToList();
            Shape.PrintShape(orderedByArea.ToList());

            Console.WriteLine("\n Shapes ordered by Perimeter \n");
            var orderedByPerimeter = ourShapes.OrderBy(p => p.Perimeter).ToList();
            Shape.PrintShape(orderedByPerimeter.ToList());

            // Q6
            Console.WriteLine("\n Shapes now in Json Format \n");
            using (FileStream fs = File.Create("JSON.txt"))
            {
                JsonSerializer.SerializeAsync(fs, ourShapes);
            }
            string strJson = JsonSerializer.Serialize<IList<Shape>>(ourShapes);
            String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON.txt");
            File.WriteAllText(path, strJson);
            Console.WriteLine(strJson);

            // Q7
            Console.WriteLine("\n Number of Instaces of Shape \n");
            Console.WriteLine(Shape.Instance);
        }


        private static List<Shape> PopulateShapes()
        {
            var _shapes = new List<Shape>();

            //Generate Shapes
            Circle circle = new (5);
            Triangle equilateralTriangle = new (10, 10, 10);
            Triangle isoscelesTriangle = new (15, 15, 5);
            Triangle scaleneTriangle = new (10, 8, 6);
            Quadrilateral square = new (10, 10);
            Quadrilateral rectangle = new (10, 6);

            // Add shapes to list of type Shape
            _shapes.Add(circle);
            _shapes.Add(equilateralTriangle);
            _shapes.Add(isoscelesTriangle);
            _shapes.Add(scaleneTriangle);
            _shapes.Add(square);
            _shapes.Add(rectangle);

            return _shapes;
        }
    }
}
