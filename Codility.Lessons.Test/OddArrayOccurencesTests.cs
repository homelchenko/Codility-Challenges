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
            int[] emptyArray = new int[0];

            Action findUnpairedAction = () => new OddArrayOccurences().FindUnpaired(emptyArray);

            // Act & Assert
            findUnpairedAction.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void FindUnpaired_WhenArrayLengthIsEven_ShouldThrow()
        {
            // Arrange
            int[] arrayOfEvenLength = new int[4];

            Action findUnpairedAction = () => new OddArrayOccurences().FindUnpaired(arrayOfEvenLength);

            // Act & Assert
            findUnpairedAction.ShouldThrow<ArgumentException>();
        }
    }
}
