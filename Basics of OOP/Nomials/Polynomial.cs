//-----------------------------------------------------------------------
// <copyright file="Polynomial.cs" company="EPAM">
// Copyright (c) Company. All rights reserved.
// </copyright>
// <author>Srazhov Miras</author>
//-----------------------------------------------------------------------

namespace BasicsOfOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents class that holds Polynomial methods
    /// </summary>
    public class Polynomial
    {
        /// <summary>Container of monomials</summary>
        private Monomial[] monomials;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynomial"/> class
        /// </summary>
        /// <param name="monomials">Monomial objects</param>
        public Polynomial(Monomial[] monomials)
        {
            char variable = monomials[0].Variable;
            if (!monomials.All(mono => mono.Variable == variable))
            {
                throw new ArgumentException();
            }

            this.monomials = monomials;
            this.PolyVar = monomials[0].Variable;
        }

        /// <summary>Gets the variable of this Polynomial object</summary>
        public char PolyVar { get; }

        /// <summary>
        /// Adds two Polynomial objects.
        /// <para>Return null if polynomials' variable are different</para>
        /// </summary>
        /// <param name="left">Left object</param>
        /// <param name="right">Right object</param>
        /// <returns>A merged polynomial</returns>
        public static Polynomial operator +(Polynomial left, Polynomial right)
        {
            if (left.PolyVar != right.PolyVar)
            {
                return null;
            }

            Monomial[] res = left.monomials.Concat(right.monomials).ToArray();
            return new Polynomial(res);
        }

        /// <summary>
        /// Checks if two Polynomials are equal
        /// </summary>
        /// <param name="left">Left object</param>
        /// <param name="right">Right object</param>
        /// <returns>Equality of two objects</returns>
        public static bool operator ==(Polynomial left, Polynomial right)
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
        /// Inverts the <see cref="operator ==(Polynomial, Polynomial)"/> method
        /// </summary>
        /// <param name="left">Left object</param>
        /// <param name="right">Right object</param>
        /// <returns>Inversion of equality operator</returns>
        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Calculates the Polynomial
        /// </summary>
        /// <returns>Shortened polynomial</returns>
        public Polynomial ShowResult()
        {
            List<Monomial> temps = new List<Monomial>(monomials);
            List<Monomial> results = new List<Monomial>();

            for (int k = 0; k < monomials.Length; k++)
            {
                for (int i = 0; i < temps.Count; i++)
                {
                    if (monomials[k] != temps[i]) 
                    {
                        if (Monomial.Add(monomials[k], temps[i], out Monomial result) && result != null)
                        {
                            temps.Remove(temps[i]);
                            temps.Remove(monomials[k]);
                            results.Add(result);
                            break;
                        }
                    }
                }
            }

            results.AddRange(temps);
            return new Polynomial(results.ToArray());
        }

        /// <returns>A string that represents the current object</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var mono in monomials)
            {
                result.Append(mono + " + ");
            }

            result.Remove(result.Length - 3, 3);
            return result.ToString();
        }

        /// <summary>
        /// Determines whether the specified object is equal to this object
        /// </summary>
        /// <param name="obj">Specified object</param>
        /// <returns>Is specified object is equal to this object</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Polynomial))
            {
                return false;
            }

            Polynomial polynomial = obj as Polynomial;
            if(monomials.Length == polynomial.monomials.Length)
            {
                foreach(var mono in monomials)
                {
                    if(!polynomial.monomials.Contains(mono))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets Hash code of this object
        /// </summary>
        /// <returns>Hash code of this object</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(monomials, PolyVar);
        }
    }
}
