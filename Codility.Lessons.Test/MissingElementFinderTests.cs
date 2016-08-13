using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class MissingElementFinderTests
    {
        [Test]
        public void FindMissingElement_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            // Act & Assert
            AssertFindMissingElementThrowsArgumentException(emptyArray);
        }

        [Test]
        public void FindMissingElement_WhenArrayIsLongerThanMaxAllowed_ShouldThrow()
        {
            // Arrange
            int[] tooLongArray = new int[100002];

            // Act & Assert
            AssertFindMissingElementThrowsArgumentException(tooLongArray);
        }

        [Test]
        public void FindMissingElement_WhenArrayContainsSingleElementOne_ShouldReturnMissingElement()
        {
            // Arrange
            var missingElementFinder = new MissingElementFinder();

            int[] oneItemArray = new int[1] { 1 };

            // Act
            int missingElement = missingElementFinder.FindMissingElement(oneItemArray);

            // Assert
            missingElement.Should().Be(2);
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
