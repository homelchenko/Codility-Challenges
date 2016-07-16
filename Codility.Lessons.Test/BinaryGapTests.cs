using System;
using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void Solution_WhenNIsZero_ShouldReturnZero()
        {
            // Arrange

            // Act & Asseert
            AssertThatThereIsNoGap(0);
        }

        [Test]
        public void Solution_WhenNIsOne_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(1);
        }

        [Test]
        public void Solution_WhenNIsFive_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(5);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void Solution_WhenNIsNine_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(9);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenNIsTen_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(10);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void Solution_WhenNIsEight_ShouldReturnZero()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(8);

            // Assert
            maxGapLength.Should().Be(0);
        }

        [Test]
        public void Solution_WhenNIsFortyOne_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(41);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenNIsThirtySeven_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(37);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenNIsTwoHundredNinetySix_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(296);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenNIsIntMax_ShouldReturnZero()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(Int32.MaxValue);

            // Assert
            maxGapLength.Should().Be(0);
        }

        [Test]
        public void Solution_WhenNIsMinusFive_ShouldReturnZero()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(-5);

            // Assert
            maxGapLength.Should().Be(0);
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
