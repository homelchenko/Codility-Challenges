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
            OddArrayOccurences arrayOccurences = CreateOddArrayOccurences();

            int[] inputArray = new int[1] { 7 };
            
            // Act
            int unpairedValue = arrayOccurences.FindUnpaired(inputArray);

            // Assert
            unpairedValue.Should().Be(7);
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
