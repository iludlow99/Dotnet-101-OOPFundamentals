using System;
using ClassLibrary106_OOP_Polymorphism_Demo_3.Models;
using ClassLibrary106_OOP_Polymorphism_Demo_3.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _60_OOP_Polymorphism_Exercise_3_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Employee _employeeElevator;

        [TestMethod]
        public void Employee_ElevatorSwipeTest_ShouldPrintToConsole()
        {
            var xService = new LunchService();
            _employeeElevator = new Employee(xService);
            _employeeElevator.SwipeCard();
        }
    }
}
