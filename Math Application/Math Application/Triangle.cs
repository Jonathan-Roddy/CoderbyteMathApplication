using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    // Child class
    public class Triangle : Shape
    {
        private readonly double _side1, _side2, _side3;
        private readonly string _name;
        public override string Name{ get { return _name; } }

        public override double Perimeter { get { return _side1 + _side2 +_side3; } }

        public override double SurfaceArea { 
            get{
                // At no point are we given the Height so we need to calculate using Heron's Formula
                // https://tutorme.com/blog/post/how-to-find-height-of-a-triangle/
                double s = (_side1 +_side2 + _side3)/ 2;
                return Math.Sqrt(s*(s-_side1) * (s - _side2) * (s - _side3));
            }
        }

        public Triangle(double side1, double side2, double side3) { 
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;

            Instance++;

            if ((side1 == side2) && (side2 == side3))
                _name = "Equilateral Trangle";
            else if ((side1 == side2) || (side1 == side3) || (side2 == side3))
                _name = "Isosceles Trangle";
            else
                _name = "Scalene Triangle";
            
        }
    }
}
