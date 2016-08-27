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

        [Test]
        public void FindMissingNumber_WhenArrayContainsOneValueThatIsNotOne_ShouldReturnOne()
        {
            // Arrange
            int[] oneItemArray = new int[1] { 2 };   

            // Act
            int missingPossitiveInteger = new MissingInteger().FindMissingNumber(oneItemArray);

            // Assert
            missingPossitiveInteger.Should().Be(1);
        }
    }
}
