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

        private static void AssertIsPermutationThrowsArgumentException(int[] array)
        {
            // Arrange
            Action isPermutation = () => new PermutationChecker().IsPermutation(array);

            // Act & Assert
            isPermutation.ShouldThrow<ArgumentException>();
        }
    }
}
