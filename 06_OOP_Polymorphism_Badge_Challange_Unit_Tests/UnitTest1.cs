using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_OOP_Polymorphism_Badge_Challange;

namespace _06_OOP_Polymorphism_Badge_Challange_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //private List<Badge> _testBadges = new List<Badge>();

        //[TestInitialize]
        //public void Arrange()
        //{
        //    var aBadge = new ABadge();
        //    var bBadge = new BBadge();
        //    var cBadge = new CBadge();

        //    badgeRepo.AddBadge(aBadge);
        //    badgeRepo.AddBadge(bBadge);
        //    badgeRepo.AddBadge(cBadge);
        //}

        [TestMethod]
        public void AddbadgesToBadgeList_ShouldSucceed()
        {
            //Arrange
            var aBadge = new ABadge();
            var bBadge = new BBadge();
            var cBadge = new CBadge();

            var badgeRepo = new BadgeRepo();

            //Act
            badgeRepo.AddBadge(aBadge);
            badgeRepo.AddBadge(bBadge);
            badgeRepo.AddBadge(cBadge);

            var expected = new List<Badge>
            {
                aBadge,
                bBadge,
                cBadge
            };

            var actual = badgeRepo.ReturnBadgeList();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckAccessLevel()
        {
            //Arrange
            var aBadge = new ABadge();
            var badgeRepo = new BadgeRepo();

            //Act
            var actualLevel1 = badgeRepo.AccessFloor(aBadge, AccessTo.Level1);
            var actualLevel2 = badgeRepo.AccessFloor(aBadge, AccessTo.Level2);
            var actualLevel3 = badgeRepo.AccessFloor(aBadge, AccessTo.Level3);

            //Assert
            Assert.IsTrue(actualLevel1);
            Assert.IsFalse(actualLevel2);
            Assert.IsFalse(actualLevel3);
        }
    }
}
