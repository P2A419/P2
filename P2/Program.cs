using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;
using P2.Wizards;
using P2.CustomMath;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length == 2)
            {
                try
                {
                    Wizard.Start(args[0], args[1]);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Invalid file path");
                    Environment.Exit(0);
                }
                catch
                {
                    Console.WriteLine("Invalid command");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("-- Wizard --");
                Console.WriteLine("Write the file path followed by the algorhithm (gaussian, density, distance)");
                string[] arguments = Console.ReadLine().Split(' ');

                try
                {
                    //Wizard.Start(@"D:/Dropbox/P2/Projekt/simdata/simdata.txt", "gaussian");
                    Wizard.Start(arguments[0], arguments[1]);
                }
                catch (FileNotFoundException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid file path");
                    Main(null);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid command");
                    Main(null);
                }
            }
            Console.ReadLine();
        }

    }
}
