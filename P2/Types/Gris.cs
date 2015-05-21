using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Types
{
    public class Gris : Type
    {
        public double Distance { get; set; }
        public double Angle { get; set; }
        public static int Counter = 0;

        public Gris(double Distance, double Angle)
        {
            Counter++;
            this.Number = Counter;
            this.Distance = Distance;
            this.Angle = Angle;
        }

        public override string ToString()
        {
            return string.Format("Number: {0}, Distance: {1}, Angle: {2}, Anomaly: {3}", Distance, Angle, Anomality);
        }
    }
}
