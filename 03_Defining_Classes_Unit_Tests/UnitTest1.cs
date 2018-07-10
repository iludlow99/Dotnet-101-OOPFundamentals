using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_ClassesExercise_1;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Employee _employee;
        [TestInitialize]
        public void Arrange()
        {
            _employee = new Employee
            {
                EmployeeId =  new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"),
                LastName = "Smith",
                Age = 32,
                NumberOfYears = 7
            };

        }


        [TestMethod]
        public void ShouldSucceed()
        {
            //Arrange
            Arrange();

            //Act
            var expectedEmployeeId = new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4");
            var expectedLastName = "Smith";
            var expectedAge = 32;
            var expectedNumberOfYears = 7;

            //Assert
            Assert.AreEqual(expectedEmployeeId, _employee.EmployeeId);
            Assert.AreEqual(expectedLastName, _employee.LastName);
            Assert.AreEqual(expectedAge, _employee.Age);
            Assert.AreEqual(expectedNumberOfYears, _employee.NumberOfYears);
        }
    }
}
