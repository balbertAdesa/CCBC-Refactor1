using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeBookClub.Refactor;

namespace CCBS_Refactor.Test
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void TestType1()
        {
            // Arrange
            var sut = new Class1();
            // Act
            var actual = sut.Calculate(500, 1, 6);
            // Assert
            Assert.AreEqual(500, actual);
        }

        [TestMethod]
        public void TestType2()
        {
            // Arrange
            var sut = new Class1();
            // Act
            var actual = sut.Calculate(500, 2, 6);
            // Assert
            Assert.AreEqual(427.500m, actual);
        }

        [TestMethod]
        public void TestType3()
        {
            // Arrange
            var sut = new Class1();
            // Act
            var actual = sut.Calculate(500, 3, 6);
            // Assert
            Assert.AreEqual(332.500m, actual);
        }

        [TestMethod]
        public void TestType4()
        {
            // Arrange
            var sut = new Class1();
            // Act
            var actual = sut.Calculate(500, 4, 6);
            // Assert
            Assert.AreEqual(237.500m, actual);
        }
    }
}
