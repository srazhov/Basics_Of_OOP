//-----------------------------------------------------------------------
// <copyright file="SortByMax.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Bubbles
{
    /// <summary>
    /// A class that holds methods that compares rows and columns
    /// </summary>
    public class SortByMax : SortBySum
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortByMax"/> class
        /// </summary>
        /// <param name="increasing">Is increasing</param>
        public SortByMax(bool increasing) : base(increasing) { }

        /// <summary>
        /// The method that compares Rows and Columns
        /// </summary>
        /// <param name="array">Array to compare</param>
        /// <param name="x1">X coordinate</param>
        /// <param name="x2">Y coordinate</param>
        /// <returns>Comparable condition</returns>
        public override bool Compare(int[,] array, int x1, int x2)
        {
            if (IsIncreasing)
            {
                if (GetMax(array, x1) > GetMax(array, x2))
                {
                    return true;
                }
            }
            else
            {
                if (GetMax(array, x1) < GetMax(array, x2))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates the max element from the given array
        /// </summary>
        /// <param name="array">This 2D array</param>
        /// <param name="position">X position of 2D array</param>
        /// <returns>Max element of the array</returns>
        protected int GetMax(int[,] array, int position)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[position, i] > max)
                {
                    max = array[position, i];
                }
            }

            return max;
        }
    }
}
