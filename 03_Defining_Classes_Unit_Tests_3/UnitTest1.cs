using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Define_Classes_Exercise_3;

namespace _03_Defining_Classes_Unit_Tests_3
{
    [TestClass]
    public class UnitTest1
    {
        private Customer _customer;
        private CustomerRepository _customerRepository;

        [TestInitialize]
        public void Arrange()
        {
            _customer = new Customer(1, "Bon Jovi", 55, 40);
            _customerRepository = new CustomerRepository();
        }

        [TestMethod]
        public void CustomerEmailTest_ReturnString()
        {
            //Act
            var actual = _customerRepository.EmailCustomer(_customer);

            var expected = "You're the best";

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
