using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class TestData
    {
        private int number;
        private int distance;
        private int degree;
        public bool normal=false;

        public TestData(int number, int distance, int degree)
        {
            this.number = number;
            this.distance = distance;
            this.degree = degree;
        }
        public void printall(){
            Console.WriteLine("linje {0} : {1} - {2}", this.number, this.distance, this.degree);
        }
    }
}
