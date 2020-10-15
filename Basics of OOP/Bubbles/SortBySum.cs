//-----------------------------------------------------------------------
// <copyright file="SortBySum.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Bubbles
{
    /// <summary>
    /// A class that holds methods that compares rows and columns
    /// </summary>
    public class SortBySum : IRowColumnComparer
    {
        /// <summary>
        /// Initializes a new instance the <see cref="SortBySum"/> class
        /// </summary>
        /// <param name="increasing">Is increasing</param>
        public SortBySum(bool increasing)
        {
            IsIncreasing = increasing;
        }

        /// <summary>
        /// Gets an answer of how to sort
        /// </summary>
        protected bool IsIncreasing { get; }

        /// <summary>
        /// The method that compares Rows and Columns
        /// </summary>
        /// <param name="array">Array to compare</param>
        /// <param name="x1">X coordinate</param>
        /// <param name="x2">Y coordinate</param>
        /// <returns>Comparable condition</returns>
        public virtual bool Compare(int[,] array, int x1, int x2)
        {
            if (IsIncreasing) {
                if (GetSum(array, x1) > GetSum(array, x2))
                {
                    return true;
                }
            }
            else
            {
                if (GetSum(array, x1) < GetSum(array, x2))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates the total sum of given array
        /// </summary>
        /// <param name="array">This 2D array</param>
        /// <param name="position">X position of 2D array</param>
        /// <returns>Sum of the array</returns>
        protected static int GetSum(int[,] array, int position)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[position, i];
            }

            return sum;
        }
    }
}
