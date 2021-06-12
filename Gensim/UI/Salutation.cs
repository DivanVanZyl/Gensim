using Gensim.Helpers;
using System;
using System.Collections.Generic;

namespace Gensim
{
    internal class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException("writer");
        }

        public void Instructions()
        {
            this.writer.Write("Bees knees.");
        }

        public void AmountOfAnimals(IManager manager)
        {
            this.writer.Write("Total amount of Animals: " + manager.Animals.Count);
        }

        public void GenerationCount(IManager manager)
        {
            List<int> pattern = Quantification.CountGenerations(manager);

            for (int cnt = 1; cnt < manager.NumberOfGenerations; cnt++)
            {
                this.writer.Write("Animals in Gerenation no." + cnt + ": " + pattern[cnt-1]);
            }
        }

        public void Hello()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            this.writer.Write(@"
O       o O       o O       o O       o O       o O       o
| O   o | | O   o | | O   o | | O   o | | O   o | | O   o |
| | O | | | | O | | | | O | | | | O | | | | O | | | | O | |
| o   O | | o   O | | o   O | | o   O | | o   O | | o   O |
o       O o       O o       O o       O o       O o       O
");
            Console.ForegroundColor = ConsoleColor.Green;
            this.writer.Write("Welcome to Gensim" + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}