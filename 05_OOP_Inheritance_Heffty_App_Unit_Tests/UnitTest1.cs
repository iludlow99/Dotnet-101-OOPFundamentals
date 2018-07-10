using System;
using _05_Inheritance_Heffty_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_OOP_Inheritance_Heffty_App_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Aaron", LanguageType.React)]
        public void CreateFrontEndJuniorDeveloper_ShouldSucceed(string name, LanguageType languageType)
        {
            //Arrange
            var developer1 = new FrontEndJuniorDeveloper(name, languageType);

            //Act
            var expectedName = name;
            var expectedLangauge = languageType;

            //Assert
            Assert.AreEqual(expectedName, developer1.Name);
            Assert.AreEqual(expectedLangauge, developer1.Language);
        }

        [TestMethod]
        public void CreateApp_ShouldSucceed()
        {
            //Arrange
            var app = new App();

            //Act


            //Assert
        }

        [TestMethod]
        [DataRow("Aaron", LanguageType.React)]
        public void ChangeFrontEndJuniorDeveloperTrainingStatus_ShouldSucceed(string name, LanguageType languageType) {
            //Arrange
            var developer1 = new FrontEndJuniorDeveloper(name, languageType);

            //Act
            var expectedCSharpTrainingStatusBefore = developer1.CheckCSharpTrainingStatus();
            developer1.SetHasDoneCSharpTraining(true);
            var expectedCSharpTrainingStatusAfter = developer1.CheckCSharpTrainingStatus();

            //Assert
            Assert.AreEqual(expectedCSharpTrainingStatusBefore, false);
            Assert.AreEqual(expectedCSharpTrainingStatusAfter, true);
        }

        //[TestMethod]
        //public void TestMethodX()
        //{
        //    //Arrange


        //    //Act


        //    //Assert
        //}
    }

}
