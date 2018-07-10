using System;
using _06_OOP_Polymorphism_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_OOP_Polymorphism_Exercise_2_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2200, 12000, 2500)]
        public void InstantiatingEmployee_ShouldSucceed(int monthlyGoal, int teamGoal, int salesToday)
        {
            //Arrange
            var salesRep = new SalesRep(monthlyGoal, teamGoal, salesToday);

            //Act
            var expectedMonthlyGoal = 2200;
            var expectedTeamGoal = 12000;
            var expectedSalesToday = 2500;

            //Assert
            Assert.AreEqual(expectedMonthlyGoal, salesRep.salesMessages.MonthlyGoal);
            Assert.AreEqual(expectedTeamGoal, salesRep.salesMessages.TeamGoal);
            Assert.AreEqual(expectedSalesToday, salesRep.salesMessages.SalesToday);
        }

        [TestMethod]
        [DataRow(2200, 12000, 2500)]
        public void CheckEmployeeLocation_ShouldBeInParkingLot(int monthlyGoal, int teamGoal, int salesToday)
        {
            //Arrange
            var salesRep = new SalesRep(monthlyGoal, teamGoal, salesToday);

            //Act
            var expectedLocation = LocationEnum.ParkingLot;

            //Assert
            Assert.AreEqual(expectedLocation, salesRep.CurrentLocation);
        }

        [TestMethod]
        [DataRow(2200, 12000, 2500)]
        public void ChangingEmployeeLocations_ShouldSucceed(int monthlyGoal, int teamGoal, int salesToday)
        {
            //Arrange
            var salesRep = new SalesRep(monthlyGoal, teamGoal, salesToday);

            //Act
            var expectedBeforeLocation = LocationEnum.ParkingLot;
            Assert.AreEqual(expectedBeforeLocation, salesRep.CurrentLocation);

            salesRep.ChangeLocation(LocationEnum.Enter);
            var expectedAfterLocation = LocationEnum.Enter;

            //Assert
            Assert.AreEqual(expectedAfterLocation, salesRep.CurrentLocation);
        }

        [TestMethod]
        [DataRow(2200, 12000, 2500)]
        public void SwipingBadgeOnEnter_ShouldReturnString(int monthlyGoal, int teamGoal, int salesToday)
        {
            //Arrange
            var salesRep = new SalesRep(monthlyGoal, teamGoal, salesToday);

            //Act
            salesRep.ChangeLocation(LocationEnum.Enter);
            var message = salesRep.SwipeBadge();

            Console.WriteLine(message);

            //Assert
            Assert.IsTrue(message.Contains("Also, remember that the team goal is for the month is"));
        }

    }
}
