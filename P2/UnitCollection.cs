using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class UnitCollection
    {
        int increment = 0;

        public string[] Headers { set; get; }
        public List<Unit> List = new List<Unit>();

        public void Add(double[] values)
        {
            List.Add(new Unit(increment, values));
            increment++;
        }

        public void FromFile(string path)
        {
            StreamReader sr = new StreamReader(File.OpenRead(path));

            Headers = sr.ReadLine().Split(';');

            while (!sr.EndOfStream)
            {
                Add(Array.ConvertAll(sr.ReadLine().Split(';'), double.Parse));
            }
        }

        public int NumberOfValues()
        {
            return List[0].Values.Count();
        }
    }
}
