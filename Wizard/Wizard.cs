using P2.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Wizards
{
    public class Wizard
    {
        public static List<Gris> Items = new List<Gris>();

        public static void Start(string Filepath, string Algorhithm)
        {
            string[] lines = File.ReadAllLines(Filepath);
            for (var i = 1; i == lines.Length; i++)
            {
                Gris g = new Gris(i, double.Parse(lines[0]), double.Parse(lines[1]));
                Items.Add(g);
            }


        }
    }
}
