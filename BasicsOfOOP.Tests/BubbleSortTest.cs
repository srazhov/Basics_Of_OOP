//-----------------------------------------------------------------------
// <copyright file="BubbleSortTest.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Tests
{
    using BasicsOfOOP.Bubbles;
    using NUnit.Framework;
    
    /// <summary>
    /// Tests of the <see cref="BubbleSort"/> class
    /// </summary>
    [TestFixture]
    public class BubbleSortTest
    {
        /// <summary>
        /// Test method of custom sorting method
        /// </summary>
        [Test]
        public void BubbleSorting_SortingByMinimal()
        {
            int[,] actual =
            {
                { 1, 754, 124 },
                { 8, 1258, 129 },
                { 9, 15, 1531 },
                { 1876, 36, 154 }
            };

            SortBySum sortingMethod = new SortBySum(true);
            BubbleSort.BubbleSorting(actual, sortingMethod);

            int[,] expected =
            {
                { 1876, 36, 154 },
                { 9, 15, 1531 },
                { 8, 1258, 129 },
                { 1, 754, 124 }
            };

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method of custom multiple conditions sorting 
        /// </summary>
        [Test]
        public void BubbleSorting_TestMultipleConditions()
        {
            int[,] actual =
            {
                { 801, 235, 124, 86 },
                { 7654, 234, 2347, 2398 },
                { 1237, 383, 820, 963 },
                { 5870, 148, 1298, 10 }
            };

            SortBySum sortingMethodBySum = new SortBySum(true);
            SortByMax sortingMethodByMax = new SortByMax(true);

            BubbleSort.BubbleSorting(actual, sortingMethodBySum, sortingMethodByMax);

            int[,] expected =
            {
                { 7654, 234, 2347, 2398 },
                { 5870, 148, 1298, 10 },
                { 1237, 383, 820, 963 },
                { 801, 235, 124, 86 }
            };

            Assert.AreEqual(expected, actual);

        }
    }
}