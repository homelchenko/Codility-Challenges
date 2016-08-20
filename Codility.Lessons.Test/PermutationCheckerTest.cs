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

            Action isPermutation = () => new PermutationChecker().IsPermutation(emptyArray);

            // Act & Assert
            isPermutation.ShouldThrow<ArgumentException>();
        }
    }
}
