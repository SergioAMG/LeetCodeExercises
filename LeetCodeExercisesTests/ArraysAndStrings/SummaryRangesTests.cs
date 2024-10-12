using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class SummaryRangesTests
    {
        private SummaryRanges summaryRanges = new();

        [Test]
        public void SummaryRangesTestOne()
        {
            //Arrange
            int[] nums = [0, 1, 2, 4, 5, 7];
            IList<string> solution = new List<string>() {"0->2", "4->5", "7"};

            //Act
            IList<string> result = summaryRanges.CalculateSummaryRanges(nums);

            //Assert
            Assert.That(solution, Is.EquivalentTo(result));
        }

        [Test]
        public void SummaryRangesTestOTwo()
        {
            //Arrange
            int[] nums = [0, 2, 3, 4, 6, 8, 9];
            IList<string> solution = new List<string>() { "0", "2->4", "6", "8->9" };

            //Act
            IList<string> result = summaryRanges.CalculateSummaryRanges(nums);

            //Assert
            Assert.That(solution, Is.EquivalentTo(result));
        }

        [Test]
        public void SummaryRangesTestThree()
        {
            //Arrange
            int[] nums = [-3, -2, -1, 0, 1, 2, 4, 5, 7];
            IList<string> solution = new List<string>() { "-3->2", "4->5", "7" };

            //Act
            IList<string> result = summaryRanges.CalculateSummaryRanges(nums);

            //Assert
            Assert.That(solution, Is.EquivalentTo(result));
        }

        [Test]
        public void SummaryRangesTestFour()
        {
            //Arrange
            int[] nums = [3];
            IList<string> solution = new List<string>() { "3" };

            //Act
            IList<string> result = summaryRanges.CalculateSummaryRanges(nums);

            //Assert
            Assert.That(solution, Is.EquivalentTo(result));
        }

        [Test]
        public void SummaryRangesTestFive()
        {
            //Arrange
            int[] nums = [];
            IList<string> solution = new List<string>();

            //Act
            IList<string> result = summaryRanges.CalculateSummaryRanges(nums);

            //Assert
            Assert.That(solution, Is.EquivalentTo(result));
        }
    }
}
