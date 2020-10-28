// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComplexNumber.cs" company="NWACC">
// Copyright (c) Northwest Arkansas Community College. All rights reserved.
// Licensed under the MIT License.
// </copyright>
// <summary>
//   Represents a Complex Number in the form (a + bi) with a real part and an imaginary part.
//   A Complex Number is a combination of a Real Number and an Imaginary Number.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NCS_HW7_GUI
{
    using System;

    /// <summary>
    /// Represents a Complex Number in the form (a + bi) with a real part and an imaginary part.
    /// </summary>
    public class ComplexNumber
    {
        #region "Constants"

        #endregion

        #region "Fields"

        #endregion

        #region "Properties"

        /// <summary>
        /// Gets and sets the real part of the complex number.
        /// </summary>
        /// <value>
        /// The real part of the complex number.
        /// </value>
        public double Real { get; set; }

        /// <summary>
        /// Gets and sets the imaginary part of the complex number.
        /// </summary>
        /// <value>
        /// The imaginary part of the complex number.
        /// </value>
        public double Imaginary { get; set; }

        #endregion

        #region "Arithmetic Operators"

        /// <summary>
        /// Implements the arithmetic unary plus (+) operation.
        /// </summary>
        /// <param name="operand">The operand.</param>
        /// <returns>
        /// The value of the operand.
        /// </returns>
        public static ComplexNumber operator +(ComplexNumber operand) => operand;

        /// <summary>
        /// Implements the arithmetic unary minus (-) operation.
        /// </summary>
        /// <param name="operand">The operand.</param>
        /// <returns>
        /// The computed numeric negation of the operand.
        /// </returns>
        public static ComplexNumber operator -(ComplexNumber operand) => 
            new ComplexNumber() 
            {
                Real = -operand.Real, 
                Imaginary = operand.Imaginary
            };

        /// <summary>
        /// Implements the arithmetic binary plus (+) operation.
        /// Calculates the sum of the addend + augend.
        /// </summary>
        /// <param name="addend">The addend.</param>
        /// <param name="augend">The augend.</param>
        /// <returns>
        /// The sum (addend + augend) of the operands.
        /// </returns>
        public static ComplexNumber operator +(ComplexNumber addend, ComplexNumber augend) => 
            new ComplexNumber() 
            {
                Real = addend.Real + augend.Real, 
                Imaginary = addend.Imaginary + augend.Imaginary
            };

        /// <summary>
        /// Implements the arithmetic binary minus (-) operation.
        /// Calculates the difference between the minuend - subtrahend.
        /// </summary>
        /// <param name="minuend">The minuend.</param>
        /// <param name="subtrahend">The subtrahend.</param>
        /// <returns>
        /// The difference (minuend - subtrahend) between the right-hand and left-hand operands.
        /// </returns>
        public static ComplexNumber operator -(ComplexNumber minuend, ComplexNumber subtrahend) =>
            new ComplexNumber() 
            {
                Real = minuend.Real - subtrahend.Real, 
                Imaginary = minuend.Imaginary - subtrahend.Imaginary
            };

        /// <summary>
        /// Implements the arithmetic binary multiplication (*) operation.
        /// Calculates the product of the multiplier * multiplicand.
        /// </summary>
        /// <param name="multiplier">The multiplier.</param>
        /// <param name="multiplicand">The multiplicand.</param>
        /// <returns>
        /// The product (multiplier * multiplicand) of the operands.
        /// </returns>
        public static ComplexNumber operator *(ComplexNumber multiplier, ComplexNumber multiplicand) => 
            new ComplexNumber()
            {
                Real = multiplier.Real * multiplicand.Real - multiplier.Imaginary * multiplicand.Imaginary,
                Imaginary = multiplier.Real * multiplicand.Imaginary + multiplicand.Real * multiplier.Imaginary
            };

        /// <summary>
        /// Implements the arithmetic binary division (/) operation.
        /// Calculates the quotient of the dividend / divisor.
        /// </summary>
        /// <param name="dividend">The dividend.
        /// The dividend must be a valid floating-point double value, Q > 0.0 .
        /// </param>
        /// <param name="divisor">The divisor.
        /// The divisor must be a valid floating-point double value, Q > 0.0 .
        /// </param>
        /// <returns>
        /// The quotient (dividend / divisor) of the left-hand and right-hand operands.
        /// </returns>
        public static ComplexNumber operator /(ComplexNumber dividend, ComplexNumber divisor)
        {
            var dividedReal =
                (((dividend.Real) * (divisor.Real)) + ((dividend.Imaginary) * (divisor.Imaginary)))
                / (Math.Pow(divisor.Real, 2D) + Math.Pow(divisor.Imaginary, 2D));
            
            var dividedImaginary = 
                (((divisor.Real) * (dividend.Imaginary)) - ((dividend.Real) * (divisor.Imaginary)))
                / (Math.Pow(divisor.Real, 2D) + Math.Pow(divisor.Imaginary, 2D));

            return new ComplexNumber()
            {
                Real = dividedReal,
                Imaginary = dividedImaginary
            };
        }

        #endregion

        #region "Relational Operators"

        /// <summary>
        /// Implements the relational equality operation.
        /// Checks if the operands are equal.
        /// If any of the operands are not a number (<see cref="Double.NaN"/>), the result
        /// of the operation is <code>false</code>. That means that the <code>NaN</code> value
        /// is neither greater than, less than, nor equal to any other <code>double</code>
        /// (or <code>float</code>) value, including <code>NaN</code>.
        /// </summary>
        /// <param name="lhs">The left-hand-side operand.</param>
        /// <param name="rhs">The right-hand-side operand.</param>
        /// <returns>
        /// <code>true</code> if the left-hand-side and right-hand-side operands are equal,
        /// otherwise, <code>false</code> if not.
        /// </returns>
        public static bool operator ==(ComplexNumber lhs, ComplexNumber rhs) => 
            !(lhs is null) &&
            lhs.Equals(rhs);

        /// <summary>
        /// Implements the relational inequality operation.
        /// Checks if the operands are not equal.
        /// If any of the operands are not a number (<see cref="Double.NaN"/>), the result
        /// of the operation is <code>false</code>. That means that the <code>NaN</code> value
        /// is neither greater than, less than, nor equal to any other <code>double</code>
        /// (or <code>float</code>) value, including <code>NaN</code>.
        /// </summary>
        /// <param name="lhs">The left-hand-side operand.</param>
        /// <param name="rhs">The right-hand-side operand.</param>
        /// <returns>
        /// <code>true</code> if the left-hand-side and right-hand-side operands are not equal,
        /// otherwise, <code>false</code> if not.
        /// </returns>
        public static bool operator !=(ComplexNumber lhs, ComplexNumber rhs) => !(lhs == rhs);

        #endregion

        #region "Functions and Methods"

        /// <summary>
        /// Determines whether the specified fields are equal to the current fields.
        /// </summary>
        /// <param name="that">the fields to compare with the current fields.</param>
        /// <returns>
        /// <code>true</code> if the specified fields are equal to the current fields;
        /// otherwise, <code>false</code> if not.
        /// </returns>
        public bool Equals(ComplexNumber that) => 
            !(that is null) &&
            (this.Real, this.Imaginary).Equals((that.Real, that.Imaginary));

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <code>true</code> if the specified object is equal to the current object;
        /// otherwise, <code>false</code> if not.
        /// </returns>
        public override bool Equals(object obj) => 
            (obj is ComplexNumber complexNumber) && this.Equals(complexNumber);

        /// <summary>
        /// Serves as the default hash function.
        /// Provides the hash code for algorithms that need quick checks of object equality.
        /// </summary>
        /// <returns>
        /// A hash code for the current object.
        /// </returns>
        public override int GetHashCode() =>
            (this.Real, this.Imaginary).GetHashCode();

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            if (this.Imaginary >= 0.0)
            { 
                return $"({this.Real} + {this.Imaginary}i)";
            }
            else
            { 
                return $"({this.Real} - {Math.Abs(this.Imaginary)}i)";
            }
        } 

        #endregion
    }
}
