using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        private const string V = "Mars";

        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", " Mars" };

            planetList.Add(" Jupiter");
            planetList.Add(" Saturn");
            planetList.Add(" Pluto");

            //planetList.Insert(1, " Venus");
            //planetList.Insert(2, " Earth");
            Console.WriteLine($"Planet List: { String.Join(',', planetList)}");

            List<string> lastPlanets = new List<string>() { " Neptune", " Uranus" };
            planetList.AddRange(lastPlanets);
            Console.WriteLine($"Combined Lists: { String.Join(',', planetList)}");

            planetList.Insert(1, " Venus");
            planetList.Insert(2, " Earth");
            Console.WriteLine($"Insert: { String.Join(',', planetList)}");

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"Rocky Planets: { String.Join(',', rockyPlanets)}");


            planetList.Remove("Pluto");
            foreach (var item in rockyPlanets)
            {
                Console.WriteLine(item);
            }

            var spacecraftLaunched = new Dictionary<string, List<string>>();
            spacecraftLaunched.Add("Mercury", new List<string> { "Viking", "Opportunity", "Curiosity" });
            spacecraftLaunched.Add("Mars", new List<string> { "Mariner", "Venera" });
            spacecraftLaunched.Add("Jupiter", new List<string> { "Mariner", "Venera" });

            foreach (var item in spacecraftLaunched.Keys)
            {
                Console.WriteLine($"{item}");
                foreach (var value in spacecraftLaunched[item])
                {
                    Console.WriteLine($"Planet: {item} Shuttle: {value}");
                }
            }
        }
    }
}
