/*
 * Divan van Zyl 2020
 * Gensim - Generation Simulator
 * Simulates previous generations of an organism.
 */
using Gensim.Genders;
using Gensim.Managers;
using System;
using System.Collections.Generic;

namespace Gensim
{
    class Program
    {
        private static void Main()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            Salutation salutation = new Salutation(writer);
            salutation.Hello();

            IManager manager = new SimpleManager
            {
                Animals = new List<IAnimal>
            {
                new Bee("Bee0", new Drone(),1)
                //new Human("Human0", new Man(),1)
            }
            };

            string str = manager.Animals[0].GetType().ToString();
            writer.Write("Animal to simulate: " + str[(str.IndexOf(".") + 1)..]);
            writer.Write("Number of generations: " + manager.NumberOfGenerations);
            writer.Write(Environment.NewLine);

            //Create ancestors
            manager.Run();

            //Display results
            salutation.GenerationCount(manager);
            salutation.AmountOfAnimals(manager);
        }
    }
}
