using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Wizard.Algorithm
{
    class Algorithm
    {
        public static void algorithm_selection(List<TestData> list)
        {

            Console.WriteLine("Vælg den algoritme der passer bedst til dit data\r\n" +
                              "Du kan vælge imellem Gaussian(1), Afstand(2), Tæthed(3");
            algorithm_switch(list);
        }
        public static void algorithm_switch(List<TestData> list)
        {
            string temp = Console.ReadLine();
            switch(temp)
            {
                case "1":
                case "gaussian":
                case "Gaussian":
                    Gaussian.gaussian_start(list);
                    break;
                case "2":
                case "afstand":
                case "Afstand":
                    Distance.distance_start(list);
                    break;
                case "3":
                case "tæthed":
                case "Tæthed":
                    Density.density_start(list);
                    break;
                default:
                    Console.WriteLine("Du indtastede ikke et brugeligt valg\r\n"+
                                      "Tryk på en vilkårlig tast for at vælge igen");
                    Console.ReadKey();
                    Console.Clear();
                    algorithm_selection(list);
                    break;
            }
        }
    }
}
