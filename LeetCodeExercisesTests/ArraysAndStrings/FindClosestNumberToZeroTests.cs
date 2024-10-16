﻿using LeetCodeExercises.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeExercisesTests.ArraysAndStrings
{
    [TestFixture]
    public class FindClosestNumberToZeroTests
    {
        private FindClosestNumberToZero findClosestNumberToZero = new ();

        [Test]
        public void FindClosestNumberTestOne()
        {
            //Arrange
            int[] testCase = [-1, -1];
            int solution = -1;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestTwo()
        {
            //Arrange
            int[] testCase = [-4, -2, 1, -4, 8];
            int solution = 1;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestThree()
        {
            //Arrange
            int[] testCase = [2, -1, 1];
            int solution = 1;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestFour()
        {
            //Arrange
            int[] testCase = [-1];
            int solution = -1;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestFive()
        {
            //Arrange
            int[] testCase = [-1, 1];
            int solution = 1;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestSix()
        {
            //Arrange
            int[] testCase = [0];
            int solution = 0;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }

        [Test]
        public void FindClosestNumberTestSeven()
        {
            //Arrange
            int[] testCase = [-1000, -1000];
            int solution = -1000;

            //Act
            int result = findClosestNumberToZero.FindClosestNumber(testCase);

            //Assert
            Assert.That(solution, Is.EqualTo(result));
        }
    }
}
