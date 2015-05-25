using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Unit
    {
        public int ID { set; get; }
        public double[] Values { set; get; }

        public Unit(int id, double[] values)
        {
            ID = id;
            Values = values;
        }

        public Vector<double> ToVector() {
            return DenseVector.OfArray(Values);
        }

        public int NumberOfValues()
        {
            return Values.Count();
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\tValues: {1}", ID, string.Join("; ", Values));
        }
    }
}
