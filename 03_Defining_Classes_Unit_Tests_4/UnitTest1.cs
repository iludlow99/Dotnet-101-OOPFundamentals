using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_4;

namespace _03_Defining_Classes_Unit_Tests_4
{
    [TestClass]
    public class UnitTest1
    {
        private SalesMembers _salesMember1;
        private SalesMembers _salesMember2;
        private SalesMembersRepository _salesMembersRepository;

        [TestInitialize]
        public void Arrange()
        {
            _salesMember1 = new SalesMembers("Smith", 5);
            _salesMember2 = new SalesMembers("Smith", 5);
            _salesMembersRepository = new SalesMembersRepository();
        }

        [TestMethod]
        public void TotalSalesForAllSalesMembers_ShouldBeTen()
        {
            //Arrange
            Arrange();

            //Act
            _salesMembersRepository.AddToList(_salesMember1);
            _salesMembersRepository.AddToList(_salesMember2);
            var totalActual = _salesMembersRepository.CalculateTotalSales();
            var totalExpected = 10;
            
            //Assert
            Assert.AreEqual(totalExpected, totalActual);
        }
    }
}
