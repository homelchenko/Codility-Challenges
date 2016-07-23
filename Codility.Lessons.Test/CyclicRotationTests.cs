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

        [Test]
        public void Solution_WhenUnitArray_ShouldReturnUnitArray()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            int[] unitArray = new int[] { 2 };
            int anyShiftSize = 1;

            // Act
            int[] rotatedArray = cyclicRotation.Solution(unitArray, anyShiftSize);

            // Assert
            rotatedArray.Should().BeEquivalentTo(unitArray);
        }
    }
}
