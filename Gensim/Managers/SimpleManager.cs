using Gensim.Genders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gensim.Managers
{
    public class SimpleManager : IManager
    {
        public int NumberOfGenerations { get; set; }
        public List<IAnimal> Animals { get; set; }
        public SimpleManager()
        {
            NumberOfGenerations = 10;
        }

        public void Run()
        {
            for (int genCount = 1; genCount < NumberOfGenerations; genCount++)
            {

                for (int animalCnt = 0; animalCnt < Animals.Count; animalCnt++)
                {
                    if (Animals[animalCnt].Generation == genCount)
                    {
                        //Create the parents of the IAnimal with index of animalCnt
                        foreach (Type RequiredGender in Animals[animalCnt].Gender.RequiredParents)
                        {
                            if (genCount > NumberOfGenerations)
                            {
                                break;
                            }
                            IGender gender = (IGender)Activator.CreateInstance(RequiredGender);
                            IAnimal newAnimal = (IAnimal)Activator.CreateInstance(Animals[animalCnt].GetType(),
                                new object[] {
                                    Animals[animalCnt].GetType().Name + (Animals.Count),
                                                                          gender,
                                                                          genCount+1
                                }
                                );
                            Animals.Add(newAnimal);
                            newAnimal.ChildIdexes.Add(animalCnt);
                        }
                    }
                }
            }
        }
    }
}
