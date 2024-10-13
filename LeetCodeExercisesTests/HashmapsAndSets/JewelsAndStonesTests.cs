using LeetCodeExercises.ArraysAndStrings;
using LeetCodeExercises.HashmapsAndSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.HashmapsAndSets
{
    [TestFixture]
    public class JewelsAndStonesTests
    {
        private JewelsAndStones jewelsAndStones = new ();

        [Test]
        public void JewelsAndStonesTestOne()
        {
            //Arrange
            string jewels = "aA";
            string stones = "aAAbbbb";
            int solution = 3;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void JewelsAndStonesTestTwo()
        {
            //Arrange
            string jewels = "z";
            string stones = "ZZ";
            int solution = 0;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void JewelsAndStonesTestThree()
        {
            //Arrange
            string jewels = "abcDEF";
            string stones = "aaabcDExxxxxxx";
            int solution = 7;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void JewelsAndStonesTestFour()
        {
            //Arrange
            string jewels = "a";
            string stones = "a";
            int solution = 1;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void JewelsAndStonesTestFive()
        {
            //Arrange
            string jewels = "a";
            string stones = "b";
            int solution = 0;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void JewelsAndStonesTestSix()
        {
            //Arrange
            string jewels = "a";
            string stones = "";
            int solution = 0;

            //Act
            int result = jewelsAndStones.NumJewelsInStonesOptimized(jewels, stones);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
