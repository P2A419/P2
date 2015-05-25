using MathNet.Numerics.LinearAlgebra;
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
        public Vector<double> Mean;
        public Matrix<double> Covariance;

        public void Train(UnitCollection units)
        {
            Mean = CalculateMean(units);
            Covariance = CalculateCovariance(units);
        }

        Matrix<double> CalculateCovariance(UnitCollection units)
        {
            Matrix<double> covariance = Matrix<double>.Build.Dense(units.NumberOfValues(), units.NumberOfValues());

            foreach (Unit unit in units.List)
            {
                Vector<double> v = unit.ToVector() - Mean;

                covariance += v.ToColumnMatrix() * v.ToRowMatrix();
            }

            covariance *= 1.0 / units.List.Count();

            return covariance;
        }

        double CalculateProbability(Unit unit)
        {
            Vector<double> v = unit.ToVector() - Mean;

            double normalizationConstant = 1.0 / (Math.Pow(2 * Math.PI, unit.NumberOfValues() / 2.0) * Math.Sqrt(Covariance.Determinant()));

            double exp = -0.5 * (v.ToRowMatrix() * Covariance.Inverse() * v.ToColumnMatrix()).At(0, 0);

            return normalizationConstant * Math.Exp(exp);
        }

        public double CalculateProbabilityLimit(UnitCollection units)
        {
            double min = 1;

            foreach (Unit unit in units.List)
            {
                double px = CalculateProbability(unit);

                if (px < min)
                {
                    min = px;
                }
            }

            return min;
        }

        public bool IsAnomaly(Unit unit, double plim)
        {
            if (CalculateProbability(unit) < plim)
            {
                return true;
            }

            return false;
        }
    }
}
