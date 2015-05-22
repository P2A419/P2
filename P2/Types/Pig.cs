using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Types
{
    class Pig : Type
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

        public override string ToString()
        {
            return String.Format("ID: {0}, Distance: {1}, Angle: {2}, Anomaly: {3}", ID, Distance, Angle, Anomality);
        }
    }
}
