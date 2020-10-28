// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="NWACC">
// Copyright (c) Northwest Arkansas Community College. All rights reserved.
// Licensed under the MIT License.
// </copyright>
// <summary>
//   A complex number calculator. This application will use operator overloading.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NCS_HW7_GUI
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The Main Form (starting point) for this calculator application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        #region "Properties"

        #endregion

        #region "Constants"

        #endregion

        #region "Functions and Methods"

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Determines whether the given first set of operands are valid; this only checks for the first set of operands.
        /// Converts the string representation of a number to its double-precision floating-point number
        /// equivalent. A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="complexNumber">When this method returns, contains the double-precision floating-
        /// point number equivalent of the <code>complexNumber</code> parameter, if the conversion succeeded,
        /// or zero if the conversion failed. The conversion fails if the <code>complexNumber</code> parameter
        /// is <code>null</code> or <see cref="Empty"/> or is not a number in a valid format. It also fails on
        /// .NET Framework and .NET Core 2.2 and earlier versions if the complex number represents a number less
        /// than <see cref="MinValue"/> or greater than <see cref="MaxValue"/>. This parameter is passed
        /// uninitialized; any value originally supplied in <code>complexNumber</code> will be overwritten.
        /// </param>
        /// <returns>
        /// <code>true</code> if the complex number was converted successfully; otherwise,
        /// <code>false</code> if not.
        /// </returns>
        private bool IsValidFirstOperand(out ComplexNumber complexNumber)
        {
            var isValidReal = double.TryParse(this.RealOneTextBox.Text, out var real);
            var isValidImaginary = double.TryParse(this.ImaginaryOneTextBox.Text, out var imaginary);

            complexNumber = new ComplexNumber();

            if (isValidReal && isValidImaginary)
            {
                complexNumber = new ComplexNumber()
                {
                    Real = real,
                    Imaginary = imaginary
                };

                return true;
            }
            else
            { 
                MessageBox.Show(
                    $"The values you entered for real ({real}) and imaginary ({imaginary}) are invalid," +
                    $" please try again.",
                    "Complex Number Check ~ Operand One",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        /// <summary>
        /// Gets the first set of operands that represent the real and imaginary
        /// parts of the first complex number.
        /// </summary>
        /// <returns>
        /// The first set of operands that make up the first complex number.
        /// </returns>
        private ComplexNumber GetOperandOne()
        {
            var complexNumber = new ComplexNumber();
            var isValid = this.IsValidFirstOperand(out complexNumber);

            if (isValid)
            {
                return complexNumber;
            } // else, the complexNumber isValid, DoNothing();
            
            return complexNumber;
        }

        /// <summary>
        /// Determines whether the given second set of operands are valid; this only checks for the second set of operands.
        /// Converts the string representation of a number to its double-precision floating-point number
        /// equivalent. A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="complexNumber">When this method returns, contains the double-precision floating-
        /// point number equivalent of the <code>complexNumber</code> parameter, if the conversion succeeded,
        /// or zero if the conversion failed. The conversion fails if the <code>complexNumber</code> parameter
        /// is <code>null</code> or <see cref="Empty"/> or is not a number in a valid format. It also fails on
        /// .NET Framework and .NET Core 2.2 and earlier versions if the complex number represents a number less
        /// than <see cref="MinValue"/> or greater than <see cref="MaxValue"/>. This parameter is passed
        /// uninitialized; any value originally supplied in <code>complexNumber</code> will be overwritten.
        /// </param>
        /// <returns>
        /// <code>true</code> if the complex number was converted successfully; otherwise,
        /// <code>false</code> if not.
        /// </returns>
        private bool IsValidSecondOperand(out ComplexNumber complexNumber)
        {
            var isValidReal = double.TryParse(this.RealTwoTextBox.Text, out var real);
            var isValidImaginary = double.TryParse(this.ImaginaryTwoTextBox.Text, out var imaginary);

            complexNumber = new ComplexNumber();

            if (isValidReal && isValidImaginary)
            {
                complexNumber = new ComplexNumber()
                {
                    Real = real,
                    Imaginary = imaginary
                };

                return true;
            }
            else
            { 
                MessageBox.Show(
                    $"The values you entered for real ({real}) and imaginary ({imaginary}) are invalid," +
                    $" please try again.",
                    "Complex Number Check ~ Operand Two",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        /// <summary>
        /// Gets the second set of operands that represent the real and imaginary
        /// parts of the second complex number.
        /// </summary>
        /// <returns>
        /// The second set of operands that make up the second complex number.
        /// </returns>
        private ComplexNumber GetOperandTwo()
        {
            var complexNumber = new ComplexNumber();
            var isValid = this.IsValidSecondOperand(out complexNumber);

            if (isValid)
            {
                return complexNumber;
            } // else, the complexNumber isValid, DoNothing();

            return complexNumber;
        }

        #endregion

        #region "Event Handlers"

        /// <summary>
        /// Handles the Click event of the AdditionButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            var addend = this.GetOperandOne();
            var augend = this.GetOperandTwo();
            var sum = addend + augend;
            
            this.ResultRichTextBox.Text = 
                $"{addend} + {augend} = {sum}";
        }

        /// <summary>
        /// Handles the Click event of the SubtractionButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            var minuend = this.GetOperandOne();
            var subtrahend = this.GetOperandTwo();
            var difference = minuend - subtrahend;
            
            this.ResultRichTextBox.Text = 
                $"{minuend} - {subtrahend} = {difference}";
        }

        /// <summary>
        /// Handles the Click event of the MultiplicationButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            var multiplier = this.GetOperandOne();
            var multiplicand = this.GetOperandTwo();
            var product = multiplier * multiplicand;

            this.ResultRichTextBox.Text = 
                $"{multiplier} * {multiplicand} = {product}";
        }

        /// <summary>
        /// Handles the Click event of the DivisionButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            var dividend = this.GetOperandOne();
            var divisor = this.GetOperandTwo();
            var quotient = dividend / divisor;
            
            this.ResultRichTextBox.Text = 
                $"{dividend} / {divisor} = {quotient}";
        }

        /// <summary>
        /// Handles the Click event of the EqualsButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            var lhs = this.GetOperandOne();
            var rhs = this.GetOperandTwo();
            
            this.ResultRichTextBox.Text = 
                $"{lhs} is equal to {rhs} = {lhs == rhs}";
        }

        /// <summary>
        /// Handles the Click event of the NotEqualsButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NotEqualsButton_Click(object sender, EventArgs e)
        {
            var lhs = this.GetOperandOne();
            var rhs = this.GetOperandTwo();
            
            this.ResultRichTextBox.Text = 
                $"{lhs} is not equal to {rhs} = {lhs != rhs}";
        }

        #endregion
    }
}
