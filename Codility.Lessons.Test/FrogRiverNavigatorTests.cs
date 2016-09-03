using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class FrogRiverNavigatorTests
    {
        [Test]
        public void CalculateTimeToOtherBank_WhenGapSizeIsOneAndLeafFallsInZeroTime_ShouldBeZero()
        {
            // Arrange
            int gapSize = 1;
            int[] schedule = new int[1] { 1 };

            // Act
            int timeToOtherBank = new FrogRiverNavigator().CalculateTimeToOtherBank(gapSize, schedule);

            // Assert
            timeToOtherBank.Should().Be(0);
        }
    }
}
