using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.tests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareArea()
        {
            //arrange
            var testSquare = new Square()
            {
                Side = 5
            };

            //act
            var area = testSquare.Area();

            //assert
            Assert.AreEqual(25, area);
        }
    }
}
