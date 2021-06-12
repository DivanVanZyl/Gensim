using Gensim;
using Gensim.Genders;
using Gensim.Helpers;
using Gensim.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GensimTests
{
    [TestClass]
    public class NumberPatternTest
    {
        [TestMethod]
        public void Human_Pattern_Run()
        {
            //Arrange
            //Create animal number pattern
            IManager manager = new SimpleManager
            {
                Animals = new List<IAnimal>
            {
                new Human("Human0", new Man(),1)
            }
            };

            //Act
            manager.Run();
            List<int> pattern = new List<int>(Quantification.CountGenerations(manager));

            //Assert
            for (int patternCnt = 0; patternCnt < manager.NumberOfGenerations; patternCnt++)
            {
                Assert.AreEqual((int)System.Math.Pow(2, patternCnt),pattern[patternCnt]);
            }
        }

        [TestMethod]
        public void Bee_Pattern_Run()
        {
            //Arrange
            //Create animal number pattern
            IManager manager = new SimpleManager
            {
                Animals = new List<IAnimal>
            {
                new Bee("Bee0", new Drone(),1)
            }
            };

            //Act
            manager.Run();
            List<int> pattern = new List<int>(Quantification.CountGenerations(manager));

            //Assert
            for (int patternCnt = 1; patternCnt <= manager.NumberOfGenerations; patternCnt++)
            {
                Assert.AreEqual((int) Gensim.Helpers.Math.Fibonacci(patternCnt), pattern[patternCnt - 1]);
            }
        }
    }

}
