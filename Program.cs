using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2.Wizards;
using System.IO;
using System.Windows.Media;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    Wizard.Start(args[0], args[1]);
                }
                catch (FileNotFoundException)
                {

                }
            }
            else
            {
                Console.WriteLine("-- Wizard --");
                Console.WriteLine("Write the file path followed by the algorhithm (gaussian, density, distance)");
                string[] arguments = Console.ReadLine().Split(' ');

                try
                {
                    //Wizard.Start(arguments[0], arguments[1]);
                    Wizard.Start(@"D:/Dropbox/P2/Projekt/simdata/simdata.txt", "gaussian");
                } catch (FileNotFoundException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid file path");
                    Main(new string[0]);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Invalid command");
                    Main(new string[0]);
                }
            }
            Console.ReadLine();
        }

    }
}
