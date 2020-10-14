//-----------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Bubbles
{
    using System.Linq;

    /// <summary>
    /// Bubble sorting class
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Default Bubble sorter
        /// <para>Sorts an array with the given method</para>
        /// </summary>
        /// <param name="array">Array to sort</param>
        /// <param name="comparer">Compare condition</param>
        public static void BubbleSorting(int[,] array, params IRowColumnComparer[] comparer)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    if (comparer.All(c => c.Compare(array, x, y)))
                    {
                        SwapArrays(array, x, y);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps elements of a 2D array
        /// </summary>
        /// <param name="array">This array</param>
        /// <param name="first">First element</param>
        /// <param name="second">Second element</param>
        private static void SwapArrays(int[,] array, int first, int second)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int temp = array[second, i];
                array[second, i] = array[first, i];
                array[first, i] = temp;
            }
        }
    }
}
