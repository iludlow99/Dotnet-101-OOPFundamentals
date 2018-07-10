using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_OOP_Encapsulation_Exercise_2;

namespace _04_OOP_Encapsulation_Unit_Tests_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateRoom_ShouldSucceed()
        {
            //Arrange
            var expectedRoomHeight = 10;
            var expectedRoomWidth = 15;
            var expectedRoomLength = 20;

            var room = new Room(10, 15, 20);

            //Act


            //Assert
            Assert.AreEqual(expectedRoomHeight, room.Height);
            Assert.AreEqual(expectedRoomWidth, room.Width);
            Assert.AreEqual(expectedRoomLength, room.Length);
        }

        [TestMethod]
        public void CalculateWallArea_ShouldSucceed()
        {
            //Arrange
            var expectedRoomHeight = 10;
            var expectedRoomWidth = 15;
            var expectedRoomLength = 20;

            var room = new Room(10, 15, 20);

            //Act
            var wallArea = room.CalculateSurfaceAreOfWall();

            //Assert
            Assert.AreEqual((expectedRoomLength * expectedRoomHeight), wallArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateRoom_ShouldThrowException()
        {
            //Arrange
            var room = new Room(13, 5, 36);

            //Act


            //Assert
        }

        [DataTestMethod]
        [DataRow(10, 15, 20)]
        public void CreateRoomWithPerams(int h, int w, int l)
        {
            // Arrange
            var room = new Room(h, w, l);

            //Act
            Console.WriteLine(room.Height);
            Console.WriteLine(room.Width);
            Console.WriteLine(room.Length);

            var expectedRoomHeight = 10;
            var expectedRoomWidth = 15;
            var expectedRoomLength = 20;

            //Assert
            Assert.AreEqual(expectedRoomHeight, room.Height);
            Assert.AreEqual(expectedRoomWidth, room.Width);
            Assert.AreEqual(expectedRoomLength, room.Length);
        }
    }
}
