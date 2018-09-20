using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProgect;
using System.Text;
using System;
using System.IO;


namespace FruitTest
{
    [TestClass]
    class CitrusTest
    {
        [TestMethod]
        public void TestCitrus_ToString()
        {
            //Arrange
            Citrus fruit = new Citrus("Key lime", "Green",2);
            string expected = "Name is: Key lime, Color is: Green, vitamin 2 gram";

            //Act
            string result = fruit.ToString();

            //Accert     
            Assert.AreEqual(expected, result);
        }
    }
}
