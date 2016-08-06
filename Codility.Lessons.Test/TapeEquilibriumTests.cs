using System;
using NUnit.Framework;
using FluentAssertions;

namespace Codility.Lessons.Test
{

    [TestFixture]
    public class TapeEquilibriumTests
    {
        [Test]
        public void FindEquilibrium_WhenEmptyArray_ShouldThrow()
        {
            // Arrange
            int[] emptyArray = new int[0];

            Action findEquilibriumAction = () => new TapeEquilibrium().FindEquilibrium(emptyArray);

            // Act & Assert
            findEquilibriumAction.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void FindEquilibrium_WhenArrayContainsSingleElement_ShouldThrow()
        {
            // Arrange
            int[] singleItemArray = new int[1] { 5 };

            Action findEquilibrium = () => new TapeEquilibrium().FindEquilibrium(singleItemArray);

            // Act & Assert
            findEquilibrium.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
