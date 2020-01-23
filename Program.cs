using System;
using System.Collections.Generic;

namespace lists_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine(" ");

            List<string> lastPlanets = new List<string>() {
                "Uranus",
                "Neptune"
            };
            lastPlanets.ForEach(planet => Console.WriteLine(planet));
            planetList.AddRange(lastPlanets);
            Console.WriteLine(" ");
            planetList.ForEach(planet => Console.WriteLine(planet));
            

        }
    }
}
