using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim
{
    public interface IManager
    {
        public int NumberOfGenerations { get; set; }
        public List<IAnimal> Animals { get; set; }
        public void Run();
    }
}
