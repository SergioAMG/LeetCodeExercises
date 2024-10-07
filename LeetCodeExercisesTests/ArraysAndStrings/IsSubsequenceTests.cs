using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class IsSubsequenceTests
    {
        private IsSubsequence isSubsequence = new();

        [Test]
        public void IsSubsequenceTestOne()
        {
            //Arrange
            string s = "aaaa";
            string t = "aaaa";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestTwo()
        {
            //Arrange
            string s = "";
            string t = "";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestThree()
        {
            //Arrange
            string s = "";
            string t = "abc";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestFour()
        {
            //Arrange
            string s = "abc";
            string t = "";
            bool solution = false;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestFive()
        {
            //Arrange
            string s = "a";
            string t = "a";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestSix()
        {
            //Arrange
            string s = "a";
            string t = "c";
            bool solution = false;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestSeven()
        {
            //Arrange
            string s = "abc";
            string t = "ahbgdc";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestEight()
        {
            //Arrange
            string s = "axc";
            string t = "ahbgdc";
            bool solution = false;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestNine()
        {
            //Arrange
            string s = "aukjol";
            string t = "appurrrrrkjqozl";
            bool solution = true;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestTen()
        {
            //Arrange
            string s = "acb";
            string t = "ahbgdc";
            bool solution = false;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void IsSubsequenceTestEleven()
        {
            //Arrange
            string s = "acb";
            string t = "ahbcde";
            bool solution = false;

            //Act
            bool resultOptimized = isSubsequence.IsSubsequenceOf(s, t);
            bool result = isSubsequence.IsSubsequenceOfString(s, t);

            //Assert
            Assert.That(solution, Is.EqualTo(resultOptimized));
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
