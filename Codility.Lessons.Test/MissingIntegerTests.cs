using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class MissingIntegerTests
    {
        [Test]
        public void FindMissingNumber_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertFindMissingNumberThrowsArgumentException(emptyArray);
        }

        [Test]
        public void FindMissingNumber_WhenArrayIsTooLong_ShouldThrow()
        {
            // Arrange
            int[] tooLongArray = new int[100001];

            // Act & Assert
            AssertFindMissingNumberThrowsArgumentException(tooLongArray);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsOneValueThatIsNotOne_ShouldReturnOne()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 2 };

            int expected = 1;

            // Act & Assert
            AssertFindMissingNumberReturns(oneItemArray, expected);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsOneValueThatIsOne_ShouldReturnTwo()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 1 };

            var expected = 2;

            // Assert
            AssertFindMissingNumberReturns(oneItemArray, expected);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsTwoConsecutiveNumbers_ShouldReturnNext()
        {
            // Arrange
            int[] twoItemArray = new int[2] { 1, 2 };

            int expected = 3;

            // Act & Assert
            AssertFindMissingNumberReturns(twoItemArray, expected);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsTwoItemsAndBothOnes_ShouldReturnTwo()
        {
            // Arrange
            int[] twoItemArray = new int[2] { 1, 1 };

            int expected = 2;

            // Act & Assert
            AssertFindMissingNumberReturns(twoItemArray, expected);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsTwoItemsAndOneIsBiggerThanLength_ShouldReturnMissinInteger()
        {
            // Arrange
            int[] array = new int[2] { 1, 4 };

            int expected = 2;

            // Act & Assert
            AssertFindMissingNumberReturns(array, expected);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsNegativeValue_ShouldReturnMissingInteger()
        {
            // Assert
            int[] arrayContainingNegative = new int[2] { 1, -1 };

            // Act & Assert
            AssertFindMissingNumberReturns(arrayContainingNegative, 2);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsZeroValue_ShouldReturnMissingInteger()
        {
            // Arrange
            int[] arrayContainingZero = new int[2] { 1, 0 };

            // Act & Assert
            AssertFindMissingNumberReturns(arrayContainingZero, 2);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsMaxPossibleLength_ShouldReturnMissingInteger()
        {
            // Arrange
            int[] longestArray = new int[MissingInteger.MaxArrayLength];

            // Act & Assert
            AssertFindMissingNumberReturns(longestArray, 1);
        }

        private static void AssertFindMissingNumberThrowsArgumentException(int[] array)
        {
            // Arrange
            MissingInteger missingInteger = CreateMissingInteger();

            Action findMissingNumber = () => missingInteger.FindMissingNumber(array);

            // Act & Assert
            findMissingNumber.ShouldThrow<ArgumentException>();
        }

        private static void AssertFindMissingNumberReturns(int[] array, int expected)
        {
            // Arrange
            MissingInteger missingInteger = CreateMissingInteger();

            // Act
            int missingPossitiveInteger = missingInteger.FindMissingNumber(array);

            // Assert
            missingPossitiveInteger.Should().Be(expected);
        }

        private static MissingInteger CreateMissingInteger()
        {
            return new MissingInteger();
        }
    }
}
