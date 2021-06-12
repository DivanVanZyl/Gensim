using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Helpers
{
    public static class Quantification
    {
        public static List<int> CountGenerations(IManager manager)
        {
            List<int> pattern = new List<int>();
            int tmpCounter = 0;
            for (int a = 1; a <= manager.NumberOfGenerations; a++)
            {
                foreach (IAnimal animal in manager.Animals)
                {
                    if (animal.Generation == a)
                    {
                        tmpCounter++;
                    }
                }
                pattern.Add(tmpCounter);
                tmpCounter = 0;
            }
            return pattern;
        }
    }
}
