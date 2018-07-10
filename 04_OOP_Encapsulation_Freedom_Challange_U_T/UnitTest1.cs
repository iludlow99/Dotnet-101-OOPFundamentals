using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Freedom_Challange;

namespace _04_OOP_Encapsulation_Freedom_Challange_U_T
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void CreateCourses()
        {
            var pythonCourse = new Course("Python 151", 10.96m);
            var javaScriptCourse = new Course("JavaScript 101", 13.76m);
        }
        [DataRow("Aaron")]
        [TestMethod]
        public void AddCoursesToDeveloperAddDeveloperToDeveloperList_ShouldSucceed(string name)
        {
            //Arrange
                //CreateCourses();
                //How do I use the courses if I make them with the createCourses method?
            var javaScriptCourse = new Course("JavaScript 101", 13.76m);
            
            var developer1 = new Developer(name); //<-- name is passed into the test method using the DataRow attribute

            var developers = new Developers();

            //Act
            developer1.AddCoursesToDeveloperCourseList(javaScriptCourse);

            developers.AddDeveloperToDevelopersList(developer1);

            var expected = 1;
            var actual = developers.GetList().Count;


            //Assert
            Assert.AreEqual(name, developer1.Name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckDeveloperBalance()
        {
            var pythonCourse = new Course("Python 151", 10.96m);

            var developer1 = new Developer("Aaron");

            var developers = new Developers();

            //Act
            developer1.AddCoursesToDeveloperCourseList(pythonCourse);

            developers.AddDeveloperToDevelopersList(developer1);

            var expectedBalance = 100m - 10.96m;
            var developersList = developers.GetList();

            var actualBalance = GetDeveloperBalanceOutOfDevelopersList(developersList, "Aaron");
            

            //Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ExceedDeveloperBudget_ShouldThrowException()
        {
            var pythonCourse = new Course("Python 151", 100.96m);

            var developer1 = new Developer("Aaron");

            //Act
            developer1.AddCoursesToDeveloperCourseList(pythonCourse);


            //Assert
        }

        public decimal GetDeveloperBalanceOutOfDevelopersList(List<Developer> developersList, string developerName)
        {
            decimal balance;
            foreach (var developer in developersList)
            {
                if (developer.Name.ToLower() == developerName.ToLower())
                {
                    balance = developer.Balance;
                    return balance;
                }

            }
            return 10000m;
        }
    }
}
