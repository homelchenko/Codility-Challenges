using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void Solution_WhenNIsZero_ShouldReturnZero()
        {
            // Arrange

            // Act & Asseert
            AssertThatThereIsNoGap(0);
        }

        [Test]
        // Rename the test
        public void Solution_WhenNIs1_ShouldReturnZero()
        {
            // Arrange

            // Act & Assert
            AssertThatThereIsNoGap(1);
        }

        [Test]
        public void Solution_WhenNIsFive_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(5);

            // Assert
            maxGapLength.Should().Be(1);
        }

        [Test]
        public void Solution_WhenNIsNine_ShouldReturnTwo()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(9);

            // Assert
            maxGapLength.Should().Be(2);
        }

        [Test]
        public void Solution_WhenNIsTen_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(10);

            // Assert
            maxGapLength.Should().Be(2);
        }

        //[Test]
        //public void ConvertToBinary_WhenZero_ShouldReturnEmpty()
        //{
        //    // Arrange
        //    var binaryGap = new BinaryGap();

        //    // Act
        //    string binary = binaryGap.ConvertToBinary(0);

        //    // Assert
        //    binary.Should().BeEmpty();
        //}

        [Test]
        public void ConvertToBinary_WhenOne_ShouldReturnOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            string binary = binaryGap.ConvertToBinary(1);

            // Assert
            binary.Should().Be("1");
        }

        [Test]
        public void ConvertToBinary_WhenThree_ShouldReturnOneOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            string binary = binaryGap.ConvertToBinary(3);

            // Assert
            binary.Should().Be("11");
        }

        [Test]
        public void ConvertToBinary_WhenFive_ShouldReturnOneZeroOne()
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            string binary = binaryGap.ConvertToBinary(5);

            // Assert
            binary.Should().Be("101");
        }

        private static void AssertThatThereIsNoGap(int input)
        {
            // Arrange
            var binaryGap = new BinaryGap();

            // Act
            int maxGapLength = binaryGap.solution(input);

            // Assert
            maxGapLength.Should().Be(0);
        }

        // TODO: Test for Int.Max
        // TODO: Test for negative input
    }
}
