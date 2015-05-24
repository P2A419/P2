using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace P2.AnomalyDetection
{
    class Algorithms
    {
        public static List<T> FileToList<T>(string path)
        {
            List<T> list = new List<T>();
            StreamReader stream = new StreamReader(File.OpenRead(path), Encoding.Default);

            while (!stream.EndOfStream)
            {
                list.Add((T)Activator.CreateInstance(typeof(T), stream.ReadLine()));
            }

            stream.Close();

            return list;
        }

        public static Vector<double> UnitToVector<T>(T unit)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            double[] p = new double[properties.Count()];

            for (int i = 0; i < properties.Count(); i++)
            {
                p[i] = (double)properties[i].GetValue(unit, null);
            }

            return DenseVector.OfArray(p);
        }

        public static Vector<double> CalculateMean<T>(ref List<T> units)
        {
            Vector<double> mean = Vector<double>.Build.Dense(typeof(T).GetProperties().Count());

            foreach (T unit in units)
            {
                Vector<double> v = UnitToVector(unit);

                mean += v;
            }

            mean *= (1.0 / units.Count);

            return mean;
        }

        public static Vector<double> CalculateStandardDeviation<T>(ref List<T> units, Vector<double> mean)
        {
            Vector<double> sd = Vector<double>.Build.Dense(typeof(T).GetProperties().Count());

            foreach (T unit in units)
            {
                Vector<double> v = UnitToVector(unit);

                sd += (v - mean).PointwisePower(2);
            }

            sd *= (1.0 / units.Count);

            return sd.PointwisePower(0.5);
        }

        public static List<T> Standardize<T>(ref List<T> units)
        {
            List<T> list = new List<T>();
            Vector<double> mean = CalculateMean(ref units);
            Vector<double> sd = CalculateStandardDeviation(ref units, mean);

            foreach (T unit in units)
            {
                list.Add((T)Activator.CreateInstance(typeof(T), (UnitToVector(unit) - mean) / sd));
            }

            return list;
        }

        public static void IsAnomaly()
        {
            //TODO fix virtual
        }
    }
}
