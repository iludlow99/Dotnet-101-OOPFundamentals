using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Exercise_1;

namespace _04_OOP_Encapsulation_Unti_Tests_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetCustomerFirstName_ShouldSucceedByThrowingException()
        {
            //Arrange
                var customer = new Customer
                {
                    FirstName = " ",
                    LastName = "P",
                    Age = 13
                };
            
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void SetCustomerAge_ShouldSucceedByThrowingException()
        //{
        //    //Arrange
        //    try
        //    {
        //        var customer = new Customer
        //        {
        //            FirstName = "Kenn",
        //            LastName = "P",
        //            Age = 130
        //        };
        //    }
        //    catch (ArgumentOutOfRangeException ex)
        //    {
        //        var expected = "You're way too old!";
        //        Console.WriteLine(ex.Message);
        //        Assert.AreEqual(expected, ex.Message);
        //    }

        //    //Act


        //    //Assert

        //}
    }
}
