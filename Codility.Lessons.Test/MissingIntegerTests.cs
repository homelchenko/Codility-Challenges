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
            AssertFindMissingIntegerThrowsArgumentException(emptyArray);
        }

        [Test]
        public void FindMissingNumber_WhenArrayIsTooLong_ShouldThrow()
        {
            // Arrange
            int[] tooLongArray = new int[100001];

            // Act & Assert
            AssertFindMissingIntegerThrowsArgumentException(tooLongArray);
        }

        [Test]
        public void FindMissingNumber_WhenArrayContainsOneValueThatIsNotOne_ShouldReturnOne()
        {
            // Arrange
            MissingInteger missingInteger = CreateMissingInteger();

            int[] oneItemArray = new int[1] { 2 };

            // Act
            int missingPossitiveInteger = missingInteger.FindMissingNumber(oneItemArray);

            // Assert
            missingPossitiveInteger.Should().Be(1);
        }

        private static void AssertFindMissingIntegerThrowsArgumentException(int[] array)
        {
            // Arrange
            MissingInteger missingInteger = CreateMissingInteger();

            Action findMissingNumber = () => missingInteger.FindMissingNumber(array);

            // Act & Assert
            findMissingNumber.ShouldThrow<ArgumentException>();
        }

        private static MissingInteger CreateMissingInteger()
        {
            return new MissingInteger();
        }
    }
}
