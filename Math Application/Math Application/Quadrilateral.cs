using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    // Child class
    class Quadrilateral : Shape
    {
        private readonly double _width, _length;

        private readonly string _name;
        public override string Name { get { return _name; } }

        public override double Perimeter { get { return (_width * _length)/2 ; } }

        public override double SurfaceArea { get{ return _width * _length; } }

        public Quadrilateral(double width, double length) {
            _width = width;
            _length = length;

            Instance++;

            if (width == length)
                _name = "Square";
            else
                _name = "Rectangle";
        }
    }
}
