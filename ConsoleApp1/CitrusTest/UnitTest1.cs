using DemoProgect;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CitrusTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFruitToString()
        {
            //Arrange
            Citrus fruit = new Citrus("Key lime", "Green",2);
            string expected = "Name: Key lime, color: Green, vitamin 2 gram";

            //Act
            string result = fruit.ToString();

            //Accert     
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
         public void TestInitialization()
        {
            //Arrange
            string expectedName = "Lemmon";
            string expectedColor = "yellow";
            double expectedVitamineC = 15;

            //Act
            Citrus citrus = new Citrus(expectedName, expectedColor, expectedVitamineC);

            //Assert
            Assert.AreEqual(expectedName, citrus.Name);
            Assert.AreEqual(expectedColor, citrus.Color);
            Assert.AreEqual(expectedVitamineC, citrus.VitamineC);
        }

    }
}
