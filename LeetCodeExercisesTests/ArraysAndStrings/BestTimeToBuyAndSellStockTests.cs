using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public  class BestTimeToBuyAndSellStockTests
    {
        private BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock = new();

        [Test]
        public void BestTimeToBuyAndSellStockTestOne()
        {
            //Arrange
            int[] testCase = [7, 1, 5, 3, 6, 4];
            int solution = 5;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestTwo()
        {
            //Arrange
            int[] testCase = [7, 6, 4, 3, 1];
            int solution = 0;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestThree()
        {
            //Arrange
            int[] testCase = [2, 1, 4, 7];
            int solution = 6;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestFour()
        {
            //Arrange
            int[] testCase = [2, 1];
            int solution = 0;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestFive()
        {
            //Arrange
            int[] testCase = [1, 2];
            int solution = 1;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestSix()
        {
            //Arrange
            int[] testCase = [1, 0];
            int solution = 0;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void BestTimeToBuyAndSellStockTestSeven()
        {
            //Arrange
            int[] testCase = [2];
            int solution = 0;

            //Act
            int result = bestTimeToBuyAndSellStock.MaxProfit(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
