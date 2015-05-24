using MathNet.Numerics.LinearAlgebra;
using P2.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.AnomalyDetection
{
    class Gaussian : Parametric
    {
        static Vector<double> Mean;
        static Matrix<double> covariance;

        public void Train<T>(ref List<T> units)
        {
            units = Standardize(ref units);
            Mean = CalculateMean(ref units);
            covariance = CalculateCovariance(ref units);
        }

        Matrix<double> CalculateCovariance<T>(ref List<T> units)
        {
            int propCount = typeof(T).GetProperties().Count();
            Matrix<double> covariance = Matrix<double>.Build.Dense(propCount, propCount);

            foreach (T unit in units)
            {
                Vector<double> v = UnitToVector(unit) - Mean;

                covariance += (1.0 / units.Count) * (v.ToColumnMatrix() * v.ToRowMatrix());
            }

            return covariance;
        }

        public double CalculatePlim<T>(ref List<T> units)
        {
            double min = 1;

            foreach (T unit in units)
            {
                double px = CalculateProbability(unit);

                if (px < min)
                {
                    min = px;
                }

            }

            return min;
        }

        double CalculateProbability<T>(T unit)
        {
            int propCount = typeof(T).GetProperties().Count();

            Vector<double> v = UnitToVector(unit) - Mean;

            double normalizationConstant = 1.0 / (Math.Pow(2 * Math.PI, propCount / 2.0) * Math.Sqrt(covariance.Determinant()));
            double exp = -0.5 * (v.ToRowMatrix() * covariance.Inverse() * v.ToColumnMatrix()).At(0, 0);

            return normalizationConstant * Math.Exp(exp);
        }

        public bool IsAnomaly<T>(T unit, double plim)
        {
            if (CalculateProbability(unit) < plim)
            {
                return true;
            }

            return false;
        }
    }
}
