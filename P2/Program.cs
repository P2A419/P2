using P2.Algorithms;
using P2.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pig> trainingData = new List<Pig>();

            StreamReader trainingStream = new StreamReader(File.OpenRead("../../data_uden_fejl.txt"));

            while (!trainingStream.EndOfStream)
            {
                var components = trainingStream.ReadLine().Split(' ');

                trainingData.Add(new Pig(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture)));
            }

            trainingStream.Close();


            //TODO Fix epsilon så det ikke skal være meget lille før de rigtige unormalheder detekteres
            Gaussian.Train(1E-150, ref trainingData); 



            List<Pig> detectionData= new List<Pig>();

            StreamReader detectionStream = new StreamReader(File.OpenRead("../../data_med_fejl.txt"));

            while (!detectionStream.EndOfStream)
            {
                var components = detectionStream.ReadLine().Split(' ');

                detectionData.Add(new Pig(double.Parse(components[0], CultureInfo.InvariantCulture), double.Parse(components[1], CultureInfo.InvariantCulture)));
            }

            detectionStream.Close();

            foreach (var item in detectionData)
            {
                if (Gaussian.IsAnormal(item))
                {
                    item.Anomality = true;
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
