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
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(8);
        }

        [Test]
        public void Solution_WhenFive_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(5);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void Solution_WhenFortyOne_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(41);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenIntMax_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(Int32.MaxValue);
        }

        [Test]
        public void Solution_WhenMinusFive_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(-5);
        }

        [Test]
        public void Solution_WhenNine_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(9);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenOne_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(1);
        }

        [Test]
        public void Solution_WhenTen_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(10);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void Solution_WhenThirtySeven_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(37);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenTwoHundredNinetySix_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(296);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenZero_ShouldReturnZero()
        {
            // Arrange

            // Act & Asseert
            AssertThatThereIsNoGap(0);
        }

        private static void AssertThatThereIsNoGap(int input)
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(input);

            // Assert
            maxGapLength.Should().Be(0);
        }
    }
}
