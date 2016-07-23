using System;
using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class CyclicRotationTests
    {
        [Test]
        public void Solution_WhenEmptyArray_ShouldReturnEmptyArray()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] emptyArray = new int[0];
            int anyShift = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(emptyArray, anyShift);

            // Assert
            rotatedArray.Should().BeEmpty();
        }

        [Test]
        public void Solution_WhenUnitArray_ShouldReturnUnitArray()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] unitArray = new int[] { 2 };
            int anyShift = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(unitArray, anyShift);

            // Assert
            rotatedArray.Should().BeEquivalentTo(unitArray);
        }

        [Test]
        public void Solution_WhenShiftIsNegative_ShouldRaiseException()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] emptyArray = new int[0];
            int negativeShift = -1;

            Action rotateAction = () => cyclicRotation.Solution(emptyArray, negativeShift);

            // Act & Assert
            rotateAction.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
