using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Globalization;
using P2.Types;
using P2.CustomMath;


namespace P2.Algorithms
{
    public class Gaussian
    {
        public static Vector Mean { get; private set; }
        public static Matrix Covariance { get; private set; }
        public static double Epsilon { get; set; }
        
        public static void Run(ref List<Gris> items)
        {
            Mean = new Vector();
            Covariance = new Matrix();
            // Calculate mean vector
            for (int i = 0; i < items.Count; i++)
            {
                Vector gris = new Vector(items[i].Distance, items[i].Angle);
                Mean += (1.0 / items.Count) * gris;
            }
            // Calculate covariance matrix
            for (int i = 0; i < items.Count; i++)
            {
                Vector grisDeviation = new Vector(new Vector(items[i].Distance, items[i].Angle) - Mean);
                Covariance = Core.MatrixAddition(Covariance, Core.ConstantVectorProduct((1.0 / items.Count), (grisDeviation * grisDeviation)));
            }
            Console.WriteLine("Training algorithm created. Enter a value for epsilon.");
            try
            {
                Epsilon = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Epsilon value stored. Enter the full filepath of the test file to check or anomalities");
            }
            catch
            {
                Epsilon = 1E-10;
                Console.WriteLine("Value could not be parsed. Defaulting to an epsilon value of 1E-10. Enter the full filepath of the test file to check or anomalities");
            }
        }
        public static bool IsAnomality(Gris g)
        {
            // Compute p(x) and flag as an anomaly if it is lower than epsilon
            Vector v = new Vector(new Vector(g.Distance, g.Angle) - Mean);
            double normalizationFactor = (1.0 / (((2.0 * Math.PI)) * Math.Sqrt(Covariance.Determinant)));
            double exp = -0.5 * (Core.VectorTransposeVectorProduct(v * Core.InvertMatrix(Covariance), v));
            double px = normalizationFactor * Math.Exp(exp);
            if (px < Epsilon)
            {
                return true;
            }
            else return false;
        }
    }
}
