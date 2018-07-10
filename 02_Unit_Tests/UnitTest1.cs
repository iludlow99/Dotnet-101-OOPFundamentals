using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Reference_Types;

namespace _02_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstantiatingCustomerShouldSucceed()
        {
            //Arrange
            Customer customer = new Customer();

            //Act
            customer.FirstName = "Isaac";
            customer.Email = "test@test.com";
            customer.PhoneNumber = "317-555-6969";

            var actualName = "Isaac";
            
            Console.WriteLine(actualName);

            //Assert
            Assert.AreEqual(actualName, customer.FirstName);
        }

        [TestMethod]
        public void InstantiatingCustomerWithConstructor_ShouldSucceed()
        {
            //Arrange
            var actualCustomer = new Customer("Adam", "adam@adam.com", "317-555-5555", 5);

            //Act
            actualCustomer.AddRewardPoints(5);

            var expectedName = "Adam";
            var expectedEmail = "adam@adam.com";
            var expectedPhoneNumber = "317-555-5555";
            var expectedRewardPoints = 10;

            //Assert
            Assert.AreEqual(expectedName, actualCustomer.FirstName);
            Assert.AreEqual(expectedEmail, actualCustomer.Email);
            Assert.AreEqual(expectedPhoneNumber, actualCustomer.PhoneNumber);
            Assert.AreEqual(expectedRewardPoints, actualCustomer.RewardPoints);
        }
    }
}
