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

        private static void AssertFindEquilibriumThrows(int[] array)
        {
            // Arrange
            Action findEquilibrium = () => new TapeEquilibrium().FindEquilibrium(array);

            // Act & Assert
            findEquilibrium.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
