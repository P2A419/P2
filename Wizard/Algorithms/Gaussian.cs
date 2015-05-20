using P2.Types; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace P2.Wizards.Algorithms
{
    public class Gaussian
    {
        public static double[] mean { get; private set; }
        public static double[,] covariance { get; private set; }
        public static void Run(ref List<Gris> items, int numparams)
        {
            double[] xn = new double[numparams];

            // Calculate mean vector and covariance matrix
            mean = new double[numparams];
            for (int i = 0; i < items.Count; i++)
            {
                xn[0] = items[i].Distance;
                xn[1] = items[i].Angle;

                mean[0] += (1.0 / items.Count) * xn[0];
                mean[1] += (1.0 / items.Count) * xn[1];
            }
            covariance = new double[numparams, numparams];
            for (int i = 0; i < items.Count; i++ )
            {
                double[] xo = new double[numparams];
                xo[0] = items[i].Distance - mean[0];
                xo[1] = items[i].Angle - mean[1];

                covariance[0, 0] += (1.0 / items.Count) * (xo[0] * xo[0]);
                covariance[0, 1] += (1.0 / items.Count) * (xo[0] * xo[1]);
                covariance[1, 0] += (1.0 / items.Count) * (xo[1] * xo[0]);
                covariance[1, 1] += (1.0 / items.Count) * (xo[1] * xo[1]);
            }
            Console.WriteLine("Test data loaded - Enter test values below. type \"q\" to quit");
        }
        public static void IsAnomality(Gris g)
        {
            Matrix dx = new Matrix();
            dx.M11 = covariance[0, 0];
            dx.M12 = covariance[0, 1];
            dx.M21 = covariance[1, 0];
            dx.M22 = covariance[1, 1];


            double[] v = new double[Gris.NumParams];
            v[0] = g.Distance - mean[0];
            v[1] = g.Angle - mean[1];
            double[] newVector = new double[Gris.NumParams];
            newVector[0] = v[0] * dx.M11 + v[1] * dx.M12;
            newVector[1] = v[0] * dx.M21 + v[1] * dx.M22;
            double res = newVector[0] * v[0] + newVector[1] * v[1];

            double px = (1.0 / (Math.Pow((2.0 * Math.PI), Gris.NumParams / 2.0) * Math.Sqrt(dx.Determinant))) * Math.Exp(-0.5 * res);
            Console.WriteLine(px);
        }

        // Helper functions - Courtesy of Dr. Gains
        public static void PrintMatrix(double[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                    Console.Write(t[i, j] + "  ");
                Console.WriteLine("");
            }
        }
        public static void PrintVector(double[] t, bool transposed = false)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (transposed) Console.Write(t[i] + "  ");
                else Console.WriteLine(t[i]);
                Console.WriteLine("");
            }
        }
        public static double[,] Transpose( double[,] m )
		{
			double[,] t = new double[m.GetLength(1),m.GetLength(0)];
			for( int i=0; i<m.GetLength(0); i++ )
				for( int j=0; j<m.GetLength(1); j++ )
					t[j,i] = m[i,j];			
 
			return t;
		}
    }
}
