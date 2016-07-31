using System;
using NUnit.Framework;

using FluentAssertions;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class OddArrayOccurencesTests
    {
        [Test]
        public void Solution_WhenArrayIsEmpty_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            Action findUnpairedAction = () => new OddArrayOccurences().FindUnpaired(emptyArray);

            // Act & Assert
            findUnpairedAction.ShouldThrow<ArgumentException>();
        }
    }
}
