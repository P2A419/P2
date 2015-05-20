using P2.Algorithms;
using P2.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace P2.Wizards
{
    public class Wizard
    {
        public static List<Unit> Items = new List<Unit>();

        public static void Start(string Filepath, string Algorithm)
        {
            if (File.Exists(Filepath))
            {
                if (Algorithm.ToLower() == "gaussian" || Algorithm.ToLower() == "density" || Algorithm.ToLower() == "distance")
                {
                    string[] lines = File.ReadAllLines(Filepath);
                    for (var i = 1; i <= lines.Length; i++)
                    {
                        var components = lines[i - 1].Split(' ');
                        Unit g = new Unit(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture));
                        Items.Add(g);
                    }
                    if (Algorithm.ToLower() == "gaussian")
                    {
                        //Console.WriteLine(Items.Count);

                        Gaussian.Run(ref Items, Unit.NumParams);
                        while (true) CommandParser(Console.ReadLine(), "gaussian");
                        //Console.WriteLine(Items.Count);
                    }
                    //Console.WriteLine(Items.Count);
                    //Console.WriteLine(Items.First());
                }
                else throw new Exception();
            }
            else throw new FileNotFoundException();
        }
        public static void CommandParser(string command, string algorithm)
        {
            if (command == "q") Environment.Exit(0);
            else if (algorithm == "gaussian")
            {
                try
                {
                    string[] components = command.Split(' ');
                    Unit g = new Unit(double.Parse(components[0]), double.Parse(components[1]));
                    Gaussian.IsAnomality(g);
                }
                catch
                {
                    Console.WriteLine("Error - wrong input");
                }
            }
        }
    }
}
