using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P2.Algorithms
{
    class Gaussian
    {
        static Vector<double> Mean;
        static Matrix<double> Covariance;
        static double Plim = 0.0005;

        static int propCount;

        public static void Train<T>(double plim, ref List<T> items)
        {
            if (plim != 0)
                Plim = plim;

            propCount = typeof(T).GetProperties().Count();

            Mean = Vector<double>.Build.Dense(propCount);
            Covariance = Matrix<double>.Build.Dense(propCount, propCount);

            CalculateMean(ref items);
            CalculateCovariance(ref items);
        }

        static Vector<double> GetItemVector<T>(T item)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            double[] p = new double[propCount];

            for (int i = 0; i < propCount; i++)
            {
                p[i] = (double)properties[i].GetValue(item, null);
            }

            return DenseVector.OfArray(p);
        }

        static void CalculateMean<T>(ref List<T> items)
        {
            foreach (T item in items)
            {
                Vector<double> v = GetItemVector(item);

                Mean += (1.0 / items.Count) * v;
            }
        }

        static void CalculateCovariance<T>(ref List<T> items)
        {
            foreach (T item in items)
            {
                Vector<double> v = GetItemVector(item) - Mean;

                Covariance += (1.0 / items.Count) * (v.ToColumnMatrix() * v.ToRowMatrix());
            }
        }

        public static bool IsAnormal<T>(T item)
        {
            Vector<double> v = GetItemVector(item) - Mean;

            double normalizationConstant = 1.0 / (Math.Pow(2 * Math.PI, propCount / 2.0) * Math.Sqrt(Covariance.Determinant()));
            double exp = -0.5 * (v.ToRowMatrix() * Covariance.Inverse() * v.ToColumnMatrix()).At(0, 0);
            double px = normalizationConstant * Math.Exp(exp);

            if (px < Plim)
            {
                return true;
            }

            return false;
        }
    }
}