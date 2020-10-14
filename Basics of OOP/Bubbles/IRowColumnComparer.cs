//-----------------------------------------------------------------------
// <copyright file="IRowColumnComparer.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Bubbles
{
    /// <summary>
    /// Exposes a method that compares Rows and Columns
    /// </summary>
    public interface IRowColumnComparer
    {
        /// <summary>
        /// The method that compares Rows and Columns
        /// </summary>
        /// <param name="array">Array to compare</param>
        /// <param name="x1">X coordinate</param>
        /// <param name="x2">Y coordinate</param>
        /// <returns>Comparable condition</returns>
        bool Compare(int[,] array, int x1, int x2);
    }
}
