using System;
using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class OddArrayOccurencesTests
    {
        [Test]
        public void FindUnpaired_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            OddArrayOccurences arrayOccurences = new OddArrayOccurences();

            int[] emptyArray = new int[0];

            Action findUnpairedAction = () => arrayOccurences.FindUnpaired(emptyArray);

            // Act & Assert
            findUnpairedAction.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void FindUnpaired_WhenArrayLengthIsEven_ShouldThrow()
        {
            // Arrange
            OddArrayOccurences arrayOccurences = CreateOddArrayOccurences();

            int[] arrayOfEvenLength = new int[4];

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
