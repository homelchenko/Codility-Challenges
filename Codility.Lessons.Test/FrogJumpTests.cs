using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class FrogJumpTests
    {
        private const int AnyJumpLength = 1;
        private const int AnyDestination = 1;
        private const int AnyOrigin = 1;

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
            JumpCalculator jumpCalculator = CreateJumpCalculator();

            int origin = 1;
            int destination = 1;

            // Act
            int jumpNumber = jumpCalculator.CalculateJumps(origin, destination, AnyJumpLength);

            // Arrange
            jumpNumber.Should().Be(0);
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
