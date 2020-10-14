//-----------------------------------------------------------------------
// <copyright file="ShapesTest.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Tests
{
    using BasicsOfOOP.Shapes;
    using NUnit.Framework;

    /// <summary>
    /// Tests of the <see cref="Square"/> class
    /// </summary>
    [TestFixture]
    public class ShapesTest
    {
        [TestCase(4, 3, 5, ExpectedResult = 6)]
        [TestCase(8, 8, 8, ExpectedResult = 27.712812921102035)]
        public double GetPerimeter_ReturnAreaOfTriangle(double a, double b, double C)
        {
            Triangle tempTriangle = new Triangle(a, b, C);
            
            return tempTriangle.GetArea();
        }
    }
}
