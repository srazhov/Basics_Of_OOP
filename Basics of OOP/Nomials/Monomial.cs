//-----------------------------------------------------------------------
// <copyright file="Monomial.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP
{
    using System;

    /// <summary>
    /// Class that represents monomial of one real variable
    /// </summary>
    public class Monomial
    {
        /// <summary>Degree of a variable</summary>
        private readonly int? degree;

        /// <summary>
        /// Initializes a new instance of the <see cref="Monomial"/> class
        /// </summary>
        /// <param name="digit">A digit of a monomial.</param>
        /// <param name="variable">A variable of a monomial. Must be a letter. Default is non-letter</param>
        /// <param name="degree">A degree of a monomial. Must be more than 0. Default is null</param>
        /// <exception cref="ArgumentOutOfRangeException">Degree must not be less than 0</exception>
        /// <exception cref="ArgumentException">Variable must be a letter</exception>
        public Monomial(double digit, char variable = '9', int? degree = null)
        {
            if (degree != null && degree < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (variable != '9' && !char.IsLetter(variable))
            {
                throw new ArgumentException();
            }

            Digit = digit;
            Variable = variable;
            this.degree = degree;
        }

        /// <summary>
        /// Gets the digit of a monomial. Can be empty
        /// </summary>
        public double Digit { get; }

        /// <summary>
        /// Gets the real variable of a monomial. Can be empty
        /// </summary>
        public char Variable { get; }

        /// <summary>
        /// Gets the degree of a monomial. Can be empty
        /// </summary>
        public int? Degree
        {
            get
            {
                if (Variable != '9')
                {
                    return degree;
                }

                return null;
            }
        }

        /// <summary>
        /// Adds two monomials, and outputs the result if adding was successful
        /// </summary>
        /// <param name="first">First monomial</param>
        /// <param name="second">Second monomial</param>
        /// <param name="result">Result of this operation</param>
        /// <returns>True if addition was successful. Otherwise, false</returns>
        public static bool Add(Monomial first, Monomial second, out Monomial result)
        {
            if (first.Degree == second.Degree && first.Variable == second.Variable)
            {
                result = new Monomial(first.Digit + second.Digit, first.Variable, first.Degree);
                if (result.Digit == 0)
                {
                    result = null;
                }

                return true;
            }
            
            result = null;
            return false;
        }

        /// <summary>
        /// Checks if two Monomials are equal
        /// </summary>
        /// <param name="left">Left object</param>
        /// <param name="right">Right object</param>
        /// <returns>Equality of two objects</returns>
        public static bool operator ==(Monomial left, Monomial right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null)
            {
                return right.Equals(left);
            }
            else if (right is null)
            {
                return left.Equals(right);
            }

            return left.Equals(right);
        }

        /// <summary>
        /// Inverts the <see cref="operator ==(Monomial, Monomial)"/> method
        /// </summary>
        /// <param name="left">Left object</param>
        /// <param name="right">Right object</param>
        /// <returns>Inversion of equality operator</returns>
        public static bool operator !=(Monomial left, Monomial right)
        {
            return !(left == right);
        }

        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            string digitStr = Digit == 0 ? string.Empty : Digit.ToString();
            string variableStr = !char.IsLetter(Variable) ? string.Empty : Variable.ToString();
            string degreeStr = Degree == null ? string.Empty : "^" + Degree.ToString();
            return $"{digitStr}{variableStr}{degreeStr}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to this object
        /// </summary>
        /// <param name="obj">Specified object</param>
        /// <returns>Is specified object is equal to this object</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Monomial))
            {
                return false;
            }

            var right = obj as Monomial;
            return Digit == right.Digit && Variable == right.Variable && Degree == right.Degree;
        }

        /// <summary>
        /// Gets Hash code of this object
        /// </summary>
        /// <returns>Hash code of this object</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Digit, Variable, Degree);
        }
    }
}
