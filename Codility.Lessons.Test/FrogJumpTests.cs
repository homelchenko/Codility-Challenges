using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class FrogJumpTests
    {
        private const int AnyJumpLength = 1;

        [Test]
        public void CalculateJumps_WhenOriginLessThanDestination_ShouldThrow()
        {
            // Arrange
            int origin = 2;
            int destination = 3;

            Action calculateJumps = () => new JumpCalculator().CalculateJumps(origin, destination, AnyJumpLength);

            // Act & Assert
            calculateJumps.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void CalculateJumps_WhenOriginIsLessThanOne_ShouldThrow()
        {
            // Arrange
            int zeroOrigin = 0;
            int anyDestination = 1;

            Action calculateJumps = () => new JumpCalculator().CalculateJumps(zeroOrigin, anyDestination, AnyJumpLength);

            // Act & Assert
            calculateJumps.ShouldThrow<ArgumentException>();
        }
    }
}
