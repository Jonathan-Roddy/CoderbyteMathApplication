using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    class Quadrilateral : Shape
    {
        private double _width, _length;
        private string _name;
        public override string Name { get { return _name; } }

        public override double Perimeter { get { return (_width * _length)/2 ; } }

        public override double SurfaceArea { get{ return _width * _length; } }

        public Quadrilateral(double width, double length) {
            _width = width;
            _length = length;

            if (width == length)
                _name = "Square";
            else
                _name = "Rectangle";
        }
    }
}
