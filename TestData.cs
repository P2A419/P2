using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class TestData
    {
        int number;
        double distance;
        double degree;
        bool normal=false;

        public TestData(int number, double distance, double degree)
        {
            this.number = number;
            this.distance = distance;
            this.degree = degree;
        }
        public TestData(bool normal)
        {
            this.normal = normal;
        }
        public void printall()
        {
            Console.WriteLine("linje {0} : {1} - {2}", this.number, this.distance, this.degree);
        }
    }
}
