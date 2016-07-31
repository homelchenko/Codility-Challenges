using System;
using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    // TODO: Test with long arrays
    // TODO: Test with big numbers

    [TestFixture]
    public class OddArrayOccurencesTests
    {
        [Test]
        public void FindUnpaired_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertThrowExceptionWithInputArray(emptyArray);
        }

        [Test]
        public void FindUnpaired_WhenArrayLengthIsEven_ShouldThrow()
        {
            // Arrange
            int[] arrayOfEvenLength = new int[4];

            // Act & Assert
            AssertThrowExceptionWithInputArray(arrayOfEvenLength);
        }

        [Test]
        public void FindUpaired_WhenArrayContainsSingleElement_ShouldReturnSingleElement()
        {
            // Arrange
            var expected = 7;

            int[] singleItemedArray = new int[1] { 7 };

            // Act & Assert
            AssertFindUnpairedValueReturns(singleItemedArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsThreeElementsAndUnpairedIsTheFirstOne_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[3] { 7, 2, 2};

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsThreeElementsAndUnpairedIsInTheMiddle_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[3] { 2, 7, 2 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsThreeElementsAndUnpairedIsTheLastOne_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[3] { 2, 2, 7 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsThreeElementAndUnpairedEqualsPaired_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[3] { 7, 7, 7 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsFiveElementsAndTwoDistinctPairsAndUnpairedElementAtTheEnd_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[5] { 1, 1, 2, 2, 7 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsFiveElementsAndTwoDistinctPairsAndUnpairedElementInTheMiddle_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[5] { 1, 1, 2, 7, 2 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsFiveElementAndTwoSamePairsAndUnpairedElementAtTheEnd_ShouldReturnUnpaired()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[5] { 2, 2, 2, 2, 7 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        [Test]
        public void FindUnpaired_WhenArrayContainsThreeElementAndAllUnpaired_ShouldReturnFirstElement()
        {
            // Arrange
            var expected = 7;

            int[] inputArray = new int[3] { 7, 5, 3 };

            // Act & Assert
            AssertFindUnpairedValueReturns(inputArray, expected);
        }

        private static void AssertFindUnpairedValueReturns(int[] inputArray, int expected)
        {
            OddArrayOccurences arrayOccurences = CreateOddArrayOccurences();

            // Act
            int unpairedValue = arrayOccurences.FindUnpaired(inputArray);

            // Assert
            unpairedValue.Should().Be(expected);
        }

        private static void AssertThrowExceptionWithInputArray(int[] arrayOfEvenLength)
        {
            // Arrange
            OddArrayOccurences arrayOccurences = CreateOddArrayOccurences();

            Action findUnpairedAction = () => arrayOccurences.FindUnpaired(arrayOfEvenLength);

            // Act & Assert
            findUnpairedAction.ShouldThrow<ArgumentException>();
        }

        private static OddArrayOccurences CreateOddArrayOccurences()
        {
            return new OddArrayOccurences();
        }
    }
}
