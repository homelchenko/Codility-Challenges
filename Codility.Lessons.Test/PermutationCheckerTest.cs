using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class PermutationCheckerTest
    {
        [Test]
        public void IsPermutation_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(emptyArray);
        }

        [Test]
        public void IsPermutation_WhenArrayIsLongerThanMaxLength_ShouldThrow()
        {
            // Arrange
            var lengthLongerThanMax = 100001;

            int[] arrayLongerThanMax = new int[lengthLongerThanMax];

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(arrayLongerThanMax);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsSingleItemAndIsOne_ShouldReturnTrue()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 1 };

            // Act & Assert
            AssertIsPermutation(oneItemArray);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsSingleItemAndIsNotOne_ShouldReturnFalse()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 2 };

            // Act & Assert
            AssertIsNotPermutation(oneItemArray);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsTwoDistinctItemsOneAndTwo_ShouldReturnTrue()
        {
            // Arrange
            int[] twoItemArray = new int[2] { 2, 1 };

            // Act & Assert
            AssertIsPermutation(twoItemArray);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsTwoItemsTwoAndThree_ShouldReturnFalse()
        {
            // Arrange
            int[] twoItemArray = new int[2] { 2, 3 };

            // Act & Assert
            AssertIsNotPermutation(twoItemArray);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsElementLessThanOneShouldThrow()
        {
            // Arrange
            int[] array = new int[2] { 1, 0 };

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(array);
        }

        [Test]
        public void IsPermutation_WhenArrayContainsElementMoreThanMax_ShouldThrow()
        {
            // Arrange
            int valueBeyondMax = 1000000001;

            int[] array = new int[2] { 1, valueBeyondMax };

            // Act & Assert
            AssertIsPermutationThrowsArgumentException(array);
        }

        private static void AssertIsPermutation(int[] array)
        {
            // Arrange
            PermutationChecker permutationChecker = CreatePermutationChecker();

            // Act
            bool isPermutation = permutationChecker.IsPermutation(array);

            // Assert
            isPermutation.Should().BeTrue();
        }

        private static void AssertIsNotPermutation(int[] array)
        {
            var permutationChecker = CreatePermutationChecker();

            // Act
            bool isPermutation = permutationChecker.IsPermutation(array);

            // Assert
            isPermutation.Should().BeFalse();
        }

        private static void AssertIsPermutationThrowsArgumentException(int[] array)
        {
            // Arrange
            PermutationChecker permutationChecker = CreatePermutationChecker();

            Action isPermutation = () => permutationChecker.IsPermutation(array);

            // Act & Assert
            isPermutation.ShouldThrow<ArgumentException>();
        }

        private static PermutationChecker CreatePermutationChecker()
        {
            return new PermutationChecker();
        }
    }
}
