using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class RomanToIntegerTests
    {
        private RomanToInteger romanToInteger = new();

        [Test]
        public void RomanToIntegerTestOne()
        {
            //Arrange
            string roman = "III";
            int solution = 3;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void RomanToIntegerTestTwo()
        {
            //Arrange
            string roman = "LVIII";
            int solution = 58;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void RomanToIntegerTestThree()
        {
            //Arrange
            string roman = "MCMXCIV";
            int solution = 1994;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void RomanToIntegerTestFour()
        {
            //Arrange
            string roman = "XXIII";
            int solution = 23;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void RomanToIntegerTestFive()
        {
            //Arrange
            string roman = "MCM";
            int solution = 1900;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void RomanToIntegerTestSix()
        {
            //Arrange
            string roman = "C";
            int solution = 100;

            //Act
            int result = romanToInteger.RomanToInt(roman);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
