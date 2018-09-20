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
    }
}
