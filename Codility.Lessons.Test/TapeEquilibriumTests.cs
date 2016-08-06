using System;
using NUnit.Framework;
using FluentAssertions;

namespace Codility.Lessons.Test
{

    [TestFixture]
    public class TapeEquilibriumTests
    {
        [Test]
        public void FindEquilibrium_WhenEmptyArray_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertFindEquilibriumThrows(emptyArray);
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsSingleElement_ShouldThrow()
        {
            // Arrange
            int[] singleItemArray = new int[1] { 5 };

            // Act & Assert
            AssertFindEquilibriumThrows(singleItemArray);
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsTwoElementAndSecondDifferenceIsGreaterThanFirstOne_ShouldReturnZero()
        {
            // Arrange
            int[] array = new int[2] { 1, -2 };
            
            // Act
            int equilibrium = new TapeEquilibrium().FindEquilibrium(array);

            // Arrange
            equilibrium.Should().Be(0);
        }

        private static void AssertFindEquilibriumThrows(int[] array)
        {
            // Arrange
            Action findEquilibrium = () => new TapeEquilibrium().FindEquilibrium(array);

            // Act & Assert
            findEquilibrium.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
