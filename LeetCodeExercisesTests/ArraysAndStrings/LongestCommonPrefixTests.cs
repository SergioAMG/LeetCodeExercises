using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class LongestCommonPrefixTests
    {
        private LongestCommonPrefix longestCommonPrefix = new();

        [Test]
        public void LongestCommonPrefixTestOne() 
        {
            //Arrange
            string[] strs = ["flower", "flow", "flight"];
            string solution = "fl";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestTwo()
        {
            //Arrange
            string[] strs = ["dog", "racecar", "car"];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestThree()
        {
            //Arrange
            string[] strs = ["", "", ""];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestFour()
        {
            //Arrange
            string[] strs = ["dog", "racedog"];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestFive()
        {
            //Arrange
            string[] strs = ["dogx", "racedog"];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestSix()
        {
            //Arrange
            string[] strs = ["dog", ""];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestSeven()
        {
            //Arrange
            string[] strs = ["catcat", "catcaxt"];
            string solution = "catca";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestEight()
        {
            //Arrange
            string[] strs = ["catcat"];
            string solution = "catcat";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestNine()
        {
            //Arrange
            string[] strs = [""];
            string solution = "";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestTen()
        {
            //Arrange
            string[] strs = ["c"];
            string solution = "c";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void LongestCommonPrefixTestEleven()
        {
            //Arrange
            string[] strs = ["car", "cart", "cars"];
            string solution = "car";

            //Act
            string result = longestCommonPrefix.CalculateLongestCommonPrefix(strs);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
