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
        public void FindEquilibrium_WhenArrayContainsTwoElementsAndFirstBiggerThanSecond_ShouldReturnPossitiveDifference()
        {
            // Arrange
            int[] array = new int[2] { 6, 2 };

            // Act & Assert
            AssertEquilibriumIs(array, 4);
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsTwoElementsAndFirstIsSmallerThanSecond_ShouldReturnPossitiveDifference()
        {
            // Arrange
            int[] array = new int[2] { 2, 6 };

            // Act & Assert
            AssertEquilibriumIs(array, 4);
        }

        //[Test]
        //public void FindEquilibrium_WhenArrayContainsTwoElement_ShouldReturnDifferenceBetweenFirstAndLast()
        //{
        //    // Arrange
        //    int[] array = new int[2] { -1, 2 };
            
        //    // Act & Assert
        //    AssertEquilibriumIs(array, 3);
        //}

        //[Test]
        //public void FindEquilibrium_WhenArrayContainsTwoElementsAndDifferenceIsNegative_ShouldReturnOppositeDifferenceBetweenFirstAndLast()
        //{
        //    // Arrange
        //    int[] array = new int[2] { -1, 2 };

        //    // Act & Assert
        //    AssertEquilibriumIs(array, 3);
        //}

        //[Test]
        //public void FindEquilibrium_WhenSeveralDiffernceAndTheyAreEqual_ShouldReturnDifference()
        //{
        //    // Arrange
        //    int[] array = new int[3] { 2, 0, 2 };

        //    // Act & Assert
        //    AssertEquilibriumIs(array, 0);
        //}

        //[Test]
        //public void FindEquilibrium_WhenMaxLengthOfArrayAndMaxValues_ShouldReturnZero()
        //{
        //    // Arrange
        //    int[] array = CreateMaxLengthArrayOfValues(1000);

        //    // Act & Assert
        //    AssertEquilibriumIs(array, 0);
        //}

        //[Test]
        //public void FindEquilibrium_WhenMaxLengthOfArrayAndMinValues_ShouldReturnZero()
        //{
        //    // Arrange
        //    int[] array = CreateMaxLengthArrayOfValues(-1000);

        //    // Act & Assert
        //    AssertEquilibriumIs(array, 0);
        //}

        private static int[] CreateMaxLengthArrayOfValues(int value)
        {
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        private static void AssertEquilibriumIs(int[] array, int expected)
        {
            // Act
            int equilibrium = CreateTapeEquilibrium().FindEquilibrium(array);

            // Arrange
            equilibrium.Should().Be(expected);
        }

        private static void AssertFindEquilibriumThrows(int[] array)
        {
            // Arrange
            Action findEquilibrium = () => CreateTapeEquilibrium().FindEquilibrium(array);

            // Act & Assert
            findEquilibrium.ShouldThrow<ArgumentOutOfRangeException>();
        }

        private static TapeEquilibrium CreateTapeEquilibrium()
        {
            return new TapeEquilibrium();
        }
    }
}
