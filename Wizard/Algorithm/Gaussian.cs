using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Wizard.Algorithm
{
    class Gaussian
    {


        public static void gaussian_start(List<TestData> list)
        {
            double m = list.Count;
            int numParams = 2;
            double[] meanVector = new double[numParams];
            

            Console.WriteLine("Du har valgt den gausiske algoritme");
            foreach (var x in list)
            {
                meanVector[0] += (1 / m) * x.distance;
                meanVector[1] += (1 / m) * x.degree;
            }

            Console.WriteLine(meanVector[0]);
            Console.WriteLine(meanVector[1]);

            

            Console.ReadKey();
        }
    }
}
