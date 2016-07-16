using System;
using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void Solution_WhenEight_ShouldReturnZero()
        {
            // Act & Assert
            AssertThatThereIsNoGap(8);
        }

        [Test]
        public void Solution_WhenFive_ShouldReturnOne()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(5, 1);
        }

        [Test]
        public void Solution_WhenFortyOne_ShouldReturnTwo()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(41, 2);
        }

        [Test]
        public void Solution_WhenIntMax_ShouldReturnZero()
        {
            // Act & Assert
            AssertThatThereIsNoGap(Int32.MaxValue);
        }

        [Test]
        public void Solution_WhenMinusFive_ShouldReturnZero()
        {
            // Act & Assert
            AssertThatThereIsNoGap(-5);
        }

        [Test]
        public void Solution_WhenNine_ShouldReturnTwo()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(9, 2);
        }

        [Test]
        public void Solution_WhenOne_ShouldReturnZero()
        {
            // Act & Assert
            AssertThatThereIsNoGap(1);
        }

        [Test]
        public void Solution_WhenTen_ShouldReturnOne()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(10, 1);
        }

        [Test]
        public void Solution_WhenThirtySeven_ShouldReturnTwo()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(37, 2);
        }

        [Test]
        public void Solution_WhenTwoHundredNinetySix_ShouldReturnTwo()
        {
            // Act & Assert
            AssertThatMaxGapIsOfLength(296, 2);
        }

        [Test]
        public void Solution_WhenZero_ShouldReturnZero()
        {
            // Act & Assert
            AssertThatThereIsNoGap(0);
        }

        private static void AssertThatMaxGapIsOfLength(int input, int expectedValueOfMaxGapLength)
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(input);

            // Assert
            maxGapLength.Should().Be(expectedValueOfMaxGapLength);
        }

        private static void AssertThatThereIsNoGap(int input)
        {
            AssertThatMaxGapIsOfLength(input, 0);
        }
    }
}
