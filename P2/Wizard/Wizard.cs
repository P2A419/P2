using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2.Algorithms;
using P2.Types;

namespace P2.Wizards
{
    public class Wizard
    {
        public static List<Gris> Items = new List<Gris>();

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
                        Gris g = new Gris(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture));
                        Items.Add(g);
                    }
                    if (Algorithm.ToLower() == "gaussian")
                    {
                        Gaussian.Run(ref Items);
                        while (true) CommandParser(Console.ReadLine(), "gaussian");
                    }
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
                if (File.Exists(command))
                {
                    string[] lines = File.ReadAllLines(command);
                    int count = 0;
                    foreach (var line in lines)
                    {
                        string[] components = line.Split(' ');
                        Gris g = new Gris(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture));
                        if (Gaussian.IsAnomality(g))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count + " anomalies were found");
                }
                else
                {
                    // Testing values manually
                    try
                    {
                        string[] components = command.Split(' ');
                        Gris g = new Gris(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture));
                        Console.WriteLine(Gaussian.IsAnomality(g));
                    }
                    catch
                    {
                        Console.WriteLine("File does not exist");
                    }

                }
            }
        }
    }
}
