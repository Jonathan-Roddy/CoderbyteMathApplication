using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Application
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Perimeter { get; }

        public abstract double SurfaceArea { get; }
    }
}
