using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class MergeStringsAlternatelyTests
    {
        private MergeStringsAlternately mergeStringsAlternately = new();

        [Test]
        public void MergeStringsAlternatelyTestOne()
        {
            //Arrange
            string word1 = "a";
            string word2 = "b";
            string solution = "ab";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void MergeStringsAlternatelyTestTwo()
        {
            //Arrange
            string word1 = "abc";
            string word2 = "pqr";
            string solution = "apbqcr";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void MergeStringsAlternatelyTestThree()
        {
            //Arrange
            string word1 = "abcdefg";
            string word2 = "pq";
            string solution = "apbqcdefg";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void MergeStringsAlternatelyTestFour()
        {
            //Arrange
            string word1 = "pq";
            string word2 = "abcdefgh";
            string solution = "paqbcdefgh";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void MergeStringsAlternatelyTestFive()
        {
            //Arrange
            string word1 = "ab";
            string word2 = "pqrs";
            string solution = "apbqrs";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void MergeStringsAlternatelyTestSix()
        {
            //Arrange
            string word1 = "abcd";
            string word2 = "pq";
            string solution = "apbqcd";

            //Act
            string result = mergeStringsAlternately.MergeAlternately(word1, word2);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
