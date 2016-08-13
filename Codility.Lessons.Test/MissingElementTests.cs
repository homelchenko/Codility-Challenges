using System;

using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class MissingElementTests
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

        private static void AssertFindMissingElementThrowsArgumentException(int[] tooLongArray)
        {
            // Arrange
            MissingElement missingElement = CreateMissingElement();

            Action findMissingElement = () => missingElement.FindMissingElement(tooLongArray);

            // Act & Assert
            findMissingElement.ShouldThrow<ArgumentException>();
        }

        private static MissingElement CreateMissingElement()
        {
            return new MissingElement();
        }
    }
}
