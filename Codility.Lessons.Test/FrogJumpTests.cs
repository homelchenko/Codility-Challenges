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

        [Test]
        public void CalculateJumps_WhenOriginLessThanDestination_ShouldThrow()
        {
            // Arrange
            int origin = 2;
            int destination = 3;

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
