//-----------------------------------------------------------------------
// <copyright file="Triangle.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Shapes
{
    using System;
    
    /// <summary>
    /// Class that represents Triangle.
    /// <para>Inherited from the <see cref="Rectangle"/> class</para>
    /// </summary>
    public class Triangle : Rectangle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        public Triangle(double a, double b, double c) : base(a, b)
        {
            C = c;
        }

        /// <summary>
        /// Gets the third side of this Shape
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Calculates the perimeter
        /// </summary>
        /// <returns>Perimeter of this shape</returns>
        public override double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Calculates the Area
        /// </summary>
        /// <returns>Area of this shape</returns>
        public override double GetArea()
        {
            double p = GetPerimeter() / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
