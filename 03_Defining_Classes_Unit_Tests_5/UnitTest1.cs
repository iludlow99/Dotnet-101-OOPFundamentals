using System;
using System.Security.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_5;

namespace _03_Defining_Classes_Unit_Tests_5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClaimMadeAfter30Days_MessageShouldSayNotValid()
        {
            //Arrange
            var claim = new _03_Defining_Classes_Exercise_5.Claim(new DateTime(2018, 6, 1), 100m);

            //Act
            var expected = "Claim is not valid. Claim has to be made within 30 days of the incident";

            //Assert
            Assert.AreEqual(expected, claim.Message);
        }

        [TestMethod]
        public void ClaimMadeForTooMuchMoney_MessageShouldSayToCallAServiceAgent()
        {
            //Arrange
            var claim = new _03_Defining_Classes_Exercise_5.Claim(new DateTime(2018, 7, 1), 100m);

            //Act
            var expected = "Please call our service agent to have your claim processed";

            //Assert
            //Assert.AreEqual(expected, );
        }

    }
}
