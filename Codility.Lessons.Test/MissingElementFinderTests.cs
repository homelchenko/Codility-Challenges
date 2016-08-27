using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class MissingElementFinderTests
    {
        [Test]
        public void FindMissingElement_WhenArrayIsEmpty_ShouldReturnOne()
        {
            // Arrange
            int[] emptyArray = new int[0];

            int expectedMissingValue = 1;

            // Act & Assert
            AssertMissingValueIs(
                emptyArray,
                expectedMissingValue);
        }

        [Test]
        public void FindMissingElement_WhenArrayIsLongerThanMaxAllowed_ShouldThrow()
        {
            // Arrange
            int[] tooLongArray = new int[100001];

            // Act & Assert
            AssertFindMissingElementThrowsArgumentException(tooLongArray);
        }

        [Test]
        public void FindMissingElement_WhenArrayContainsSingleElementOne_ShouldReturnMissingElement()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 1 };

            int expectedMissingValue = 2;

            // Act & Assert
            AssertMissingValueIs(
                oneItemArray,
                expectedMissingValue);
        }

        [Test]
        public void FindMissingElement_WhenArrayContainsSingleElementTwo_ShouldReturnOne()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 2 };

            int expectedMissingValue = 1;

            // Act & Assert
            AssertMissingValueIs(
                oneItemArray,
                expectedMissingValue);
        }

        [Test]
        public void FindMissingValue_WhenArrayContainsTwoElementsAndNoThree_ShouldReturnThree()
        {
            // Assert
            int[] twoItemArray = new int[2] { 1, 2 };

            int expectedMissingValue = 3;

            // Act & Assert
            AssertMissingValueIs(
                twoItemArray,
                expectedMissingValue);
        }

        [Test]
        public void FindMissingValue_WhenArrayIsLongest_ShouldReturnMissingValue()
        {
            // Arrange
            int[] longestArray = CreateLongestPossibleArray(1);

            int expectedMissingValue = 100001;

            // Act & Assert
            AssertMissingValueIs(
                longestArray,
                expectedMissingValue);
        }

        [Test]
        public void FindMissingValue_WhenArrayContainsMaxPossibleSum_ShouldReturnOne()
        {
            // Arrange
            int[] maxPossibleSumArray = CreateLongestPossibleArray(2);

            int expectedMissingValue = 1;

            // Act & Assert
            AssertMissingValueIs(
                maxPossibleSumArray,
                expectedMissingValue);
        }

        private static int[] CreateLongestPossibleArray(int seed)
        {
            int[] maxPossibleSumArray = new int[MissingElementFinder.MaxArrayLength];

            maxPossibleSumArray.SeedWithSeries(seed);

            return maxPossibleSumArray;
        }

        private static void AssertMissingValueIs(int[] oneItemArray, int expectedMissingValue)
        {
            // Arrange
            var missingElementFinder = new MissingElementFinder();

            // Act
            int missingElement = missingElementFinder.FindMissingElement(oneItemArray);

            // Assert
            missingElement.Should().Be(expectedMissingValue);
        }

        private static void AssertFindMissingElementThrowsArgumentException(int[] tooLongArray)
        {
            // Arrange
            MissingElementFinder missingElementFinder = CreateMissingElement();

            Action findMissingElement = () => missingElementFinder.FindMissingElement(tooLongArray);

            // Act & Assert
            findMissingElement.ShouldThrow<ArgumentException>();
        }

        private static MissingElementFinder CreateMissingElement()
        {
            return new MissingElementFinder();
        }
    }
}
