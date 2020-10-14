//-----------------------------------------------------------------------
// <copyright file="Square.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Shapes
{
    /// <summary>
    /// Class that represents Square.
    /// <para>Inherited from the <see cref="Rectangle"/> class</para>
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class
        /// </summary>
        /// <param name="a">Sides of this square</param>
        public Square(double a) : base(a, a)
        {

        }
    }
}
