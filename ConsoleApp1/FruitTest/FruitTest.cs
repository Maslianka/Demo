using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProgect;
using System.Text;
using System;
using System.IO;

namespace FruitTest
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void TestFruitToString()
        {
            //Arrange
            Fruit fruit = new Fruit("Avokado", "Green");
            string expected = "Name: Avokado, color: Green";

            //Act
            string result = fruit.ToString();

            //Accert     
            Assert.AreEqual(expected, result);
        }

    }
}
