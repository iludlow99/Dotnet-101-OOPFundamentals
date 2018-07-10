using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_ClassesExercise_2;

namespace _03_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AddingDevelopersToDeveloperTeamListAndThenToTeamsList_()
        {
            //Arrange
            var developerTeam = new Team();

            //Act
            developerTeam.CreateDeveloper(1, "Kevin", true);
            developerTeam.CreateDeveloper(1, "Aaron", true);
            var teamCount = developerTeam.ReturnTeamList().Count;
            

            //Assert
            Assert.AreEqual(2, teamCount);
        }
    }
}
