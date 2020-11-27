using Gensim;
using Gensim.Genders;
using Gensim.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GensimTests
{
    [TestClass]
    public class ManagerTest
    {
        [TestMethod]
        public void Manager_Simple_Run()
        {
            //Arrange
            string name = "Barry";
            Type gender = typeof(Drone);
            IManager manager = new SimpleManager
            {
                Animals = new List<IAnimal>
            {
                new Bee(name, (IGender)Activator.CreateInstance(gender),1)
            }
            };

            //Act
            manager.Run();

            //Assert
            Assert.AreEqual(gender, manager.Animals[0].Gender.GetType());
            Assert.AreEqual(typeof(Queen), manager.Animals[1].Gender.GetType());
        }
    }
}
