using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gensim;
using Gensim.Genders;
using System;

namespace GensimTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Animal_InstantiateNew()
        {
            //Arrange
            string name = "Barry";
            int generation = 1;
            Type gender = typeof(Drone);

            IAnimal animal = new Bee(name, (IGender)Activator.CreateInstance(gender), generation);

            //Act


            //Assert
            Assert.AreEqual(gender, animal.Gender.GetType());
            Assert.AreEqual(generation, animal.Generation);
            Assert.AreEqual(name, animal.Name);
        }
    }
}
