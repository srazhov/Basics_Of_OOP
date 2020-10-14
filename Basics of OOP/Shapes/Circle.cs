//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Shapes
{
    using System;

    /// <summary>
    /// Class that represents Circle.
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Represents the PI constant
        /// </summary>
        public const double PI = Math.PI;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class
        /// </summary>
        /// <param name="radius">Radius of this circle</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Gets the radius of this Circle
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Calculates the perimeter from radius
        /// </summary>
        /// <returns>Perimeter of this circle</returns>
        public virtual double GetPerimeter()
        {
            return 2 * PI * Radius;
        }

        /// <summary>
        /// Calculates the area from radius
        /// </summary>
        /// <returns>Area of this circle</returns>
        public virtual double GetArea()
        {
            return PI * Math.Pow(Radius, 2);
        }
    }
}
