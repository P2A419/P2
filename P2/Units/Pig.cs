using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Units
{
    class Pig : Unit
    {
        public int ID;
        public double Distance { get; set; }
        public double Angle { get; set; }

        public Pig(double distance, double angle)
        {
            this.ID = Increment++;
            this.Distance = distance;
            this.Angle = angle;
        }

        public Pig(Vector<double> v)
        {
            this.ID = Increment++;
            this.Distance = v[0];
            this.Angle = v[1];
        }

        public Pig(string s)
        {
            var c = s.Split(' ');

            this.ID = Increment++;
            this.Distance = double.Parse(c[0], CultureInfo.InvariantCulture);
            this.Angle = double.Parse(c[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Distance: {1}, Angle: {2}, Anomaly: {3}", ID, Distance, Angle, Anomality);
        }
    }
}
