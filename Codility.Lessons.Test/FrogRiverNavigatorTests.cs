using System;
using FluentAssertions;

using NUnit.Framework;

namespace Codility.Lessons.Test
{
    [TestFixture]
    public class FrogRiverNavigatorTests
    {
        private const int Never = -1;

        [Test]
        public void CalculateTimeToOtherBank_WhenGapSizeIsOneAndLeafFallsInZeroTime_ShouldBeZero()
        {
            // Arrange
            int gapSize = 1;
            int[] schedule = new int[1] { 1 };

            // Act & Assert
            AssertTimeToOtherBankIs(
                gapSize,
                schedule,
                expectedTime: 0);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapSizeIsTwoAndLeafFallsOnlyAtPositionOne_ShouldBeNever()
        {
            // Arrange
            int gapSize = 2;
            int[] schedule = new int[1] { 1 };

            // Act & Assert
            AssertTimeToOtherBankIs(
                gapSize,
                schedule,
                expectedTime: Never);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenLeafFallsBeyondRiverGap_ShouldThrowException()
        {
            // Arrange
            int gapSize = 1;

            int[] scheduleBeyondRiverGap = new int[1] { 2 };

            // Act & Assert
            AssertCalculateTimeToOtherBankThrowsArgumentException(gapSize, scheduleBeyondRiverGap);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenLefaFallsBeforeRiverGap_ShouldThrowException()
        {
            // Arrange
            int gapSize = 1;

            int[] scheduleBeforeRiverGap = new int[1] { 0 };
            
            // Act & Assert
            AssertCalculateTimeToOtherBankThrowsArgumentException(gapSize, scheduleBeforeRiverGap);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenThereIsNoSchedule_ShouldThrow()
        {
            // Arrange
            int gapSize = 1;

            int[] emptySchedule = new int[0];

            // Act & Assert
            AssertCalculateTimeToOtherBankThrowsArgumentException(gapSize, emptySchedule);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapIsLessThanUnit_ShouldThrow()
        {
            // Arrange
            int emptyGapSize = 0;

            int[] schedule = new int[1] { 0 };

            // Act & Assert
            AssertCalculateTimeToOtherBankThrowsArgumentException(emptyGapSize, schedule);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapIsTwoAndLeafsFallInSequence_ShouldBeTwo()
        {
            // Arrange
            int gapSize = 2;

            int[] schedule = new int[2] { 1, 2 };
            
            // Act & Assert
            AssertTimeToOtherBankIs(
                gapSize,
                schedule,
                expectedTime: 1);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapIsTwoAndLeafsFallInPositionSeveralTimes_ShouldBeEarliestTime()
        {
            // Arrange
            int gapSize = 2;

            int[] schedule = new int[3] { 1, 2, 1 };
            
            // Act & Assert
            AssertTimeToOtherBankIs(
                gapSize,
                schedule,
                expectedTime: 1);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenLeafsFallInSamePositionButDontCoverLastBit_ShouldBeNever()
        {
            // Arrange
            int gapSize = 2;

            int[] schedule = new int[2] { 1, 1 };

            // Act & Assert
            AssertTimeToOtherBankIs(
                gapSize,
                schedule,
                expectedTime: Never);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapSizeIsMaxAllowedAndScheduleIsShortest_ShouldBeNever()
        {
            // Arrange
            int[] oneItemSchedule = new int[1] { 1 };
            
            // Act & Assert
            AssertTimeToOtherBankIs(
                FrogRiverNavigator.MaxAllowedGapSize,
                oneItemSchedule,
                expectedTime: Never);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenBothGapAndScheduleSizesAreMaxAllowed_ShouldBeMaxValue()
        {
            // Arrange
            int[] longestPossibleSchedule = new int[100000];

            longestPossibleSchedule.SeedWithSeries(1);
            
            // Act & Assert
            AssertTimeToOtherBankIs(
                FrogRiverNavigator.MaxAllowedGapSize,
                longestPossibleSchedule,
                expectedTime: 99999);
        }

        [Test]
        public void CalculateTimeToOtherBank_WhenGapSizeIsMoreThanMaxAllowed_ShouldThrow()
        {
            // Arrange
            int longerThanAllowedGapSize = 100001;

            int[] schedule = new int[1] { 1 };

            // Act & Assert
            AssertCalculateTimeToOtherBankThrowsArgumentException(
                longerThanAllowedGapSize,
                schedule);
        }

        private static void AssertCalculateTimeToOtherBankThrowsArgumentException(int gapSize, int[] schedule)
        {
            // Arrange
            Action calculateTimeToOtherBank = () => new FrogRiverNavigator().CalculateTimeToOtherBank(gapSize, schedule);

            // Act & Assert
            calculateTimeToOtherBank.ShouldThrow<ArgumentException>();
        }

        private static void AssertTimeToOtherBankIs(int gapSize, int[] schedule, int expectedTime)
        {
            // Act
            int timeToOtherBank = new FrogRiverNavigator().CalculateTimeToOtherBank(gapSize, schedule);

            // Assert
            timeToOtherBank.Should().Be(expectedTime);
        }
    }
}
