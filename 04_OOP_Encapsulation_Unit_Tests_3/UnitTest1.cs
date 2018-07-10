using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Exercise_3;

namespace _04_OOP_Encapsulation_Unit_Tests_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDriverYoungAge16_ShouldSucceed()
        {
            //Arrange
            var driver = new Driver(16);

            //Act
            var expected = 120m * 1.9m;
            var actual = driver.CostOfInsurancePerMonth;

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void CreateDriverAge20_ShouldSucceed()
        {
            //Arrange
            var driver = new Driver(20);

            //Act
            var expected = 120m * 1.6m;
            var actual = driver.CostOfInsurancePerMonth;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CreateDriverOldAge23_ShouldSucceed()
        {
            //Arrange
            var driver = new Driver(23);

            //Act
            var expected = 120m * 1.5m;
            var actual = driver.CostOfInsurancePerMonth;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateDriverAge34_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            var driver = new Driver(34);

            //Act
            

            //Assert

        }
    }
}
