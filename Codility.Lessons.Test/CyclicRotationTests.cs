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
            int anyShiftSize = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(emptyArray, anyShiftSize);

            // Assert
            rotatedArray.Should().BeEmpty();
        }
    }
}
