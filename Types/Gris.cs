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

        public Gris(int Number, double Distance, double Angle)
        {
            this.Number = Number;
            this.Distance = Distance;
            this.Angle = Angle;
        }
    }
}
