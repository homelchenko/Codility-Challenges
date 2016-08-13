using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class FrogJumpTests
    {
        private const int AnyOrigin = 1;
        private const int AnyDestination = 1;
        private const int AnyJumpLength = 1;

        [Test]
        public void CalculateJumps_WhenOriginMoreThanDestination_ShouldThrow()
        {
            // Arrange
            int origin = 3;
            int destination = 2;

            // Act & Assert
            AssertCalculateJumpsThrowsArgumentException(origin, destination, AnyJumpLength);
        }

        [Test]
        public void CalculateJumps_WhenOriginIsLessThanOne_ShouldThrow()
        {
            // Arrange
            int zeroOrigin = 0;

            // Act & Assert
            AssertCalculateJumpsThrowsArgumentException(zeroOrigin, AnyDestination, AnyJumpLength);
        }

        [Test]
        public void CalculateJumps_WhenDestinationIsLessThanOne_ShouldThrow()
        {
            // Arrange
            int zeroDestination = 0;

            // Act & Assert
            AssertCalculateJumpsThrowsArgumentException(AnyOrigin, zeroDestination, AnyJumpLength);
        }

        [Test]
        public void CalculateJumps_WhenJumpLengthIsLessThanOne_ShouldThrow()
        {
            // Arrange
            int zeroJumpLength = 0;

            // Act & Arrange
            AssertCalculateJumpsThrowsArgumentException(AnyOrigin, AnyDestination, zeroJumpLength);
        }

        [Test]
        public void CalculateJumps_WhenOriginAndDestinationAreSame_ShouldReturnZero()
        {
            // Arrange
            int origin = 1;
            int destination = 1;

            int expectedJumpNumber = 0;

            // Arrange & Act & Assert
            AssertJumpNumberIs(
                origin,
                destination,
                AnyJumpLength,
                expectedJumpNumber);
        }

        [Test]
        public void CalculateJumps_WhenDestinationIsInOneJump_ShouldReturnOne()
        {
            // Arrange
            int origin = 1;
            int destination = 2;
            int unitJumpLength = 1;

            int expectedJumpNumber = 1;

            // Arrange & Act & Assert
            AssertJumpNumberIs(
                origin,
                destination,
                unitJumpLength,
                expectedJumpNumber);
        }

        [Test]
        public void CalculateJumps_WhenDestinationIsInWholeNumberOfJumps_ShouldReturnThatNumberOfJumps()
        {
            // Arrange
            int origin = 1;
            int destination = 5;
            int jumpLength = 2;

            int expectedJumpNumber = 2;

            // Arrange & Act & Assert
            AssertJumpNumberIs(
                origin,
                destination,
                jumpLength,
                expectedJumpNumber);
        }

        private static void AssertJumpNumberIs(int origin, int destination, int jumpLength, int expectedJumpNumber)
        {
            // Arrange
            var jumpCalculator = new JumpCalculator();

            // Act
            int jumpNumber = jumpCalculator.CalculateJumps(origin, destination, jumpLength);

            // Assert
            jumpNumber.Should().Be(expectedJumpNumber);
        }

        private static void AssertCalculateJumpsThrowsArgumentException(int origin, int destination, int anyJumpLength)
        {
            JumpCalculator jumpCalculator = CreateJumpCalculator();

            Action calculateJumps = () => jumpCalculator.CalculateJumps(origin, destination, anyJumpLength);

            // Act & Assert
            calculateJumps.ShouldThrow<ArgumentException>();
        }

        private static JumpCalculator CreateJumpCalculator()
        {
            return new JumpCalculator();
        }
    }
}
