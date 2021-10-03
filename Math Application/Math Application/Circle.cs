using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public override string Name { get { return "Circle"; } }

        public override double Perimeter{ get { return 2.0 * Math.PI * _radius; } }
        
        public override double SurfaceArea { get { return Math.PI * _radius * _radius; } }

        public Circle(double radius) {
            _radius = radius;

            Instance++;
        }

    }
}
