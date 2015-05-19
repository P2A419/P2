using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2.Wizards;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {

            }
            else
            {
                Console.WriteLine("-- Wizard --");
                Console.WriteLine("Write the file path followed by the algorhithm (gaussian, density, distance)");
                string[] arguments = Console.ReadLine().Split(' ');
                Wizard.Start(arguments[0], arguments[1]);

            }
            Console.ReadLine();
        }
    }
}
