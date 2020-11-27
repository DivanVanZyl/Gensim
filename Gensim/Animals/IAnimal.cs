using System.Collections.Generic;

namespace Gensim
{
    public interface IAnimal
    {
        string Name { get; set; }
        IGender Gender { get; set; }
        int Generation { get; set; }
        List<int> ChildIdexes { get; set; }
    }
}
