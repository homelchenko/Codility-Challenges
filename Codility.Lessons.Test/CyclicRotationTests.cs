﻿using System;
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

        [Test]
        public void Solution_WhenShiftIsMoreThan100_ShouldRaiseException()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] emptyArray = new int[0];
            int moreThan100Shift = 101;

            Action rotateAction = () => cyclicRotation.Solution(emptyArray, moreThan100Shift);

            // Act & Assert
            rotateAction.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Solution_WhenShiftIsZero_ShouldReturnSameArray()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] array = new int[] { -1, 3, -5, 2, -4 };
            int zeroShift = 0;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, zeroShift);

            // Act 
            rotatedArray.Should().BeEquivalentTo(array);
        }

        [Test]
        public void Solution_WhenShiftIsOne_ShouldRotationHappen()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int unitShift = 1;

            int[] array = new [] { -1, 3, -5, 2, -4 };
            
            // Act
            int[] rotatedArray = cyclicRotation.Solution(array, unitShift);

            // Assert
            rotatedArray.Should().BeEquivalentTo(new int[] { -4, -1, 3, -5, 2 } );
        }
    }
}
