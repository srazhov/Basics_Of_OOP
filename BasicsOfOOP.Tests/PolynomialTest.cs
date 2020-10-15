//-----------------------------------------------------------------------
// <copyright file="PolynomialTest.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Tests of the <see cref="Polynomial"/> class
    /// </summary>
    [TestFixture]
    public class PolynomialTest
    {
        /// <summary>
        /// Test of the <see cref="Monomial.ToString"/> method
        /// </summary>
        [TestCase(4, 'x', 5, ExpectedResult = "4x^5")]
        [TestCase(-15, 'y', null, ExpectedResult = "-15y")]
        [TestCase(69, '9', null, ExpectedResult = "69")]
        [TestCase(0, 'z', 5, ExpectedResult = "z^5")]
        [TestCase(69, '9', 5, ExpectedResult = "69")]
        public string Monomial_ToString_Test(double digit, char character, int? degree)
        {
            Monomial monomial = new Monomial(digit, character, degree);

            string actual = monomial.ToString();

            return actual;
        }

        /// <summary>
        /// Test of the <see cref="Polynomial.ToString"/> method
        /// </summary>
        [Test]
        public void Polynomial_ToString_Test()
        {
            Monomial[] inputs = new Monomial[5]
            {
                new Monomial(420, 'x', 2),
                new Monomial(15, 'x', 3),
                new Monomial(67, 'x', 2),
                new Monomial(-156, 'x', 2),
                new Monomial(85, 'x', 0),
            };

            Polynomial polynomial = new Polynomial(inputs);

            string actual = polynomial.ToString();

            string expected = "420x^2 + 15x^3 + 67x^2 + -156x^2 + 85x^0";

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test of the <see cref="Monomial.Add(Monomial, Monomial, out Monomial)"/> method
        /// </summary>
        [Test]
        public void Monomial_Add_Test()
        {
            Monomial first = new Monomial(235, 'x', 2);
            Monomial second = new Monomial(-35, 'x', 2);

            Monomial.Add(first, second, out Monomial actual);

            Monomial expected = new Monomial(200, 'x', 2);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test of the <see cref="Polynomial.ShowResult"/> method
        /// </summary>
        [Test]
        public void Polynomial_GetResult_Test()
        {
            Monomial[] monomialsTest = new Monomial[4]
            {
                new Monomial(5, 'x', 2),
                new Monomial(2, 'x', 3),
                new Monomial(-6, 'x', 2),
                new Monomial(4, 'x', 1)
            };

            Monomial[] monomialsExpected = new Monomial[]
            {
                new Monomial(-1, 'x', 2),
                new Monomial(2, 'x', 3),
                new Monomial(4, 'x', 1)
            };

            Polynomial polynomial = new Polynomial(monomialsTest);
            Polynomial actual = polynomial.ShowResult();

            Polynomial expected = new Polynomial(monomialsExpected);

            Assert.AreEqual(expected, actual);
        }
    }
}