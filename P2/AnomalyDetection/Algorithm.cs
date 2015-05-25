using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.AnomalyDetection
{
    class Algorithm
    {
        public Vector<double> CalculateMean(UnitCollection units)
        {
            Vector<double> mean = Vector<double>.Build.Dense(units.NumberOfValues());

            foreach (Unit unit in units.List)
            {
                Vector<double> v = unit.ToVector();

                mean += v;
            }

            mean *= 1.0 / units.List.Count();

            return mean;
        }

        public Vector<double> CalculateStandardDeviation(UnitCollection units, Vector<double> mean)
        {
            Vector<double> sd = Vector<double>.Build.Dense(units.NumberOfValues());

            foreach (Unit unit in units.List)
            {
                Vector<double> v = unit.ToVector();

                sd += (v - mean).PointwisePower(2);
            }

            sd *= 1.0 / units.List.Count();

            return sd.PointwisePower(0.5);
        }

        public UnitCollection Standardize(UnitCollection units)
        {
            UnitCollection standardized = new UnitCollection();

            Vector<double> mean = CalculateMean(units);
            Vector<double> sd = CalculateStandardDeviation(units, mean);

            foreach (Unit unit in units.List)
            {
                standardized.Add(((unit.ToVector() - mean) / sd).ToArray());
            }

            return standardized;
        }

    }
}
