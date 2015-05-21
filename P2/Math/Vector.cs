using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace P2.CustomMath
{
    public class Vector
    {
        public double X1 { get; set; }
        public double X2 { get; set; }

        public Vector()
        {
            this.X1 = 0;
            this.X2 = 0;
        }
        public Vector(double X1, double X2)
        {
            this.X1 = X1;
            this.X2 = X2;
        }
        public Vector(Vector v)
        {
            this.X1 = v.X1;
            this.X2 = v.X2;
        }
        public override string ToString()
        {
            return X1 + ";" + X2;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X1 + v2.X1, v1.X2 + v2.X2);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X1 - v2.X1, v1.X2 - v2.X2);
        }
        public static Vector operator *(double k, Vector v1)
        {
            return new Vector(k * v1.X1, k * v1.X2);
        }
        public static Matrix operator *(Vector v1, Vector v2)
        {
            return new Matrix(v1.X1 * v2.X1, v1.X1 * v2.X2, v1.X2 * v2.X1, v1.X2 * v2.X2, 0, 0);
        }
        public static Vector operator *(Vector v, Matrix m)
        {
            return new Vector(v.X1 * m.M11 + v.X2 * m.M21, v.X1 * m.M12 + v.X2 * m.M22);
        }
    }
}
