//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Shapes
{
    /// <summary>
    /// Class that represents Rectangle form 
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Gets the first side of this Shape
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Gets the second side of this Shape
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Calculates the perimeter
        /// </summary>
        /// <returns>Perimeter of this shape</returns>
        public virtual double GetPerimeter()
        {
            return 2 * (A + B);
        }

        /// <summary>
        /// Calculates the Area
        /// </summary>
        /// <returns>Area of this shape</returns>
        public virtual double GetArea()
        {
            return A * B;
        }
    }
}
