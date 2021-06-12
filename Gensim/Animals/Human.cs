using Gensim.Genders;
using System.Collections.Generic;

namespace Gensim
{
    public class Human : IAnimal
    {
        public IGender Gender { get; set; }
        public int Generation { get; set; }
        public List<int> ChildIdexes { get; set; }
        public string Name { get; set; }

        public Human(string name, IGender gender, int generation)
        {
            Name = name;
            Gender = gender;
            Generation = generation;
            ChildIdexes = new List<int>();
        }
    }
}