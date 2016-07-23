using System;
using NUnit.Framework;

using FluentAssertions;

using Codility.Test.Extensions.FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class CyclicRotationTests
    {
        [Test]
        public void Solution_WhenEmptyArray_ShouldReturnEmptyArray()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int[] emptyArray = new int[0];
            int anyShift = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(emptyArray, anyShift);

            // Assert
            rotatedArray.Should().BeEmpty();
        }

        [Test]
        public void Solution_WhenUnitArray_ShouldReturnSameArray()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int[] unitArray = new int[] { 2 };
            int anyShift = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(unitArray, anyShift);

            // Assert
            rotatedArray.Should().Be(unitArray);
        }

        [Test]
        public void Solution_WhenShiftIsNegative_ShouldRaiseException()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int[] emptyArray = new int[0];
            int negativeShift = -1;

            Action rotateAction = () => cyclicRotation.Solution(emptyArray, negativeShift);

            // Act & Assert
            rotateAction.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Solution_WhenShiftIsMoreThan100_ShouldRaiseException()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int[] emptyArray = new int[0];
            int moreThan100ItemShift = 101;

            Action rotateAction = () => cyclicRotation.Solution(emptyArray, moreThan100ItemShift);

            // Act & Assert
            rotateAction.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Solution_WhenShiftIsZero_ShouldReturnSameArray()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int[] array = new int[] { -1, 3, -5, 2, -4 };
            int zeroShift = 0;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, zeroShift);

            // Act 
            rotatedArray.Should().Be(array);
        }

        [Test]
        public void Solution_WhenShiftIsOne_ShouldRotationHappen()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int oneItemShift = 1;

            int[] array = new [] { -1, 3, -5, 2, -4 };
            
            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, oneItemShift);

            // Assert
            rotatedArray.Should().Be(new int[] { -4, -1, 3, -5, 2 });
        }

        [Test]
        public void Solution_WhenShiftIsTwo_ShouldRotationHappen()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int twoItemShift = 2;

            int[] array = new[] { -1, 3, -5, 2, -4 };

            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, twoItemShift);

            // Assert
            rotatedArray.Should().Be(new int[] { 2, -4, -1, 3, -5 });
        }

        [Test]
        public void Solution_WhenShiftIsMoreThanArrayLength_ShouldRotationHappen()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int shift = 7;

            int[] array = new[] { -1, 3, -5, 2, -4 };

            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, shift);

            // Assert
            rotatedArray.Should().Be(new int[] { 2, -4, -1, 3, -5 });
        }

        [Test]
        public void Solution_WhenShiftIsSomeTimesArrayLength_ShouldRotationHappen()
        {
            // Arrange
            CyclicRotation cyclicRotation = CreateCyclicRotation();

            int shift = 10;

            int[] array = new[] { -1, 3, -5, 2, -4 };

            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, shift);

            rotatedArray.Should().Be(array);
        }

        private static CyclicRotation CreateCyclicRotation()
        {
            return new CyclicRotation();
        }
    }
}
