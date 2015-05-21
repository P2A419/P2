using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using P2.CustomMath;

namespace P2.CustomMath
{
    public class Core
    {
        public static Vector MatrixVectorProduct(Matrix m, Vector v)
        {
            return new Vector(m.M11 * v.X1 + m.M12 * v.X2 ,m.M21 * v.X1 + m.M22 * v.X2);
        }
        public static double VectorTransposeVectorProduct(Vector v1, Vector v2)
        {
            return v1.X1 * v2.X1 + v1.X2 * v2.X2;
        }
        public static Matrix ConstantVectorProduct(double k, Matrix m)
        {
            return new Matrix(k * m.M11, k * m.M12, k * m.M21, k * m.M22, 0, 0);
        }
        public static Matrix MatrixAddition(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.M11 + m2.M11, m1.M12 + m2.M12, m1.M21 + m2.M21, m1.M22 + m2.M22, 0, 0);
        }
        public static Matrix InvertMatrix(Matrix m)
        {
            Matrix t = m;
            t.Invert();
            return t;
        }
    }
}
