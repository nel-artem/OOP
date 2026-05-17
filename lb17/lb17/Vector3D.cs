using System;
using System.Collections.Generic;
using System.Text;

namespace lb17
{
    class Vector3D : Norm
    {
        double x, y, z;
        public Vector3D(double x, double y, double z) { this.x = x; this.y = y; this.z = z; }
        public override double Modulus()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public override double Norm2()
        {
            return Math.Max(Math.Abs(x), Math.Max(Math.Abs(y), Math.Abs(z)));
        }
    }
}
