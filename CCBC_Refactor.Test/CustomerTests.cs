using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeBookClub.Refactor;


namespace CCBS_Refactor.Test
{
    [TestClass]
    public class CustomerTests
    {

        BaseCustomer sut;
        [TestMethod]
        public void TestType1()
        {
            // Arrange
            sut = new DefaultCustomer(6);
            // Act
            var actual = sut.Calculate(500);
            // Assert
            Assert.AreEqual(500, actual);
        }

        [TestMethod]
        public void TestType2()
        {
            // Arrange
            sut = new Type2Customer(6);
            // Act
            var actual = sut.Calculate(500);
            // Assert
            // Assert
            Assert.AreEqual(427.500m, actual);
        }

        [TestMethod]
        public void TestType3()
        {
            // Arrange
            sut = new Type3Customer(6);
            // Act
            var actual = sut.Calculate(500);
            // Assert
            Assert.AreEqual(332.500m, actual);
        }

        [TestMethod]
        public void TestType4()
        {
            // Arrange
            sut = new Type4Customer(6);
            // Act
            var actual = sut.Calculate(500);
            // Assert
            Assert.AreEqual(237.500m, actual);
        }
    }
}
