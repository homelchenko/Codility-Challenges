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

            Action findMissingNumber = () => new MissingInteger().FindMissingNumber(emptyArray);

            // Act & Assert
            findMissingNumber.ShouldThrow<ArgumentException>();
        }
    }
}
