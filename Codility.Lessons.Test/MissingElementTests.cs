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

            Action findMissingElement = () => new MissingElement().FindMissingElement(emptyArray);

            // Act & Assert
            findMissingElement.ShouldThrow<ArgumentException>();
        }
    }
}
