namespace NCS_HW7_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.NotEqualsButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.OperandTwoGroupBox = new System.Windows.Forms.GroupBox();
            this.RealTwoTextBox = new System.Windows.Forms.TextBox();
            this.ImaginaryTwoTextBox = new System.Windows.Forms.TextBox();
            this.RealTwoLabel = new System.Windows.Forms.Label();
            this.ImaginaryTwoLabel = new System.Windows.Forms.Label();
            this.OperandOneGroupBox = new System.Windows.Forms.GroupBox();
            this.RealOneTextBox = new System.Windows.Forms.TextBox();
            this.ImaginaryOneTextBox = new System.Windows.Forms.TextBox();
            this.RealOneLabel = new System.Windows.Forms.Label();
            this.ImaginaryOneLabel = new System.Windows.Forms.Label();
            this.OperationsGroupBox.SuspendLayout();
            this.OperandTwoGroupBox.SuspendLayout();
            this.OperandOneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(311, 22);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(48, 17);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(314, 63);
            this.ResultRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(375, 229);
            this.ResultRichTextBox.TabIndex = 12;
            this.ResultRichTextBox.Text = "";
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.NotEqualsButton);
            this.OperationsGroupBox.Controls.Add(this.DivisionButton);
            this.OperationsGroupBox.Controls.Add(this.EqualsButton);
            this.OperationsGroupBox.Controls.Add(this.MultiplicationButton);
            this.OperationsGroupBox.Controls.Add(this.AdditionButton);
            this.OperationsGroupBox.Controls.Add(this.SubtractionButton);
            this.OperationsGroupBox.Location = new System.Drawing.Point(23, 312);
            this.OperationsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.OperationsGroupBox.Size = new System.Drawing.Size(417, 108);
            this.OperationsGroupBox.TabIndex = 11;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Operations";
            // 
            // NotEqualsButton
            // 
            this.NotEqualsButton.Location = new System.Drawing.Point(11, 72);
            this.NotEqualsButton.Margin = new System.Windows.Forms.Padding(4);
            this.NotEqualsButton.Name = "NotEqualsButton";
            this.NotEqualsButton.Size = new System.Drawing.Size(120, 28);
            this.NotEqualsButton.TabIndex = 5;
            this.NotEqualsButton.Text = "Not Equals";
            this.NotEqualsButton.UseVisualStyleBackColor = true;
            this.NotEqualsButton.Click += new System.EventHandler(this.NotEqualsButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(11, 23);
            this.EqualsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(120, 28);
            this.EqualsButton.TabIndex = 4;
            this.EqualsButton.Text = "Equals";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(291, 72);
            this.DivisionButton.Margin = new System.Windows.Forms.Padding(4);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(113, 28);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.Text = "Division";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(291, 23);
            this.MultiplicationButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(113, 28);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.Text = "Multiplication";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Location = new System.Drawing.Point(154, 72);
            this.SubtractionButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(113, 28);
            this.SubtractionButton.TabIndex = 1;
            this.SubtractionButton.Text = "Subtraction";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Location = new System.Drawing.Point(154, 23);
            this.AdditionButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(113, 28);
            this.AdditionButton.TabIndex = 0;
            this.AdditionButton.Text = "Addition";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // OperandTwoGroupBox
            // 
            this.OperandTwoGroupBox.Controls.Add(this.RealTwoTextBox);
            this.OperandTwoGroupBox.Controls.Add(this.ImaginaryTwoTextBox);
            this.OperandTwoGroupBox.Controls.Add(this.RealTwoLabel);
            this.OperandTwoGroupBox.Controls.Add(this.ImaginaryTwoLabel);
            this.OperandTwoGroupBox.Location = new System.Drawing.Point(23, 169);
            this.OperandTwoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.OperandTwoGroupBox.Name = "OperandTwoGroupBox";
            this.OperandTwoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.OperandTwoGroupBox.Size = new System.Drawing.Size(267, 123);
            this.OperandTwoGroupBox.TabIndex = 10;
            this.OperandTwoGroupBox.TabStop = false;
            this.OperandTwoGroupBox.Text = "Operand Two";
            // 
            // RealTwoTextBox
            // 
            this.RealTwoTextBox.Location = new System.Drawing.Point(111, 41);
            this.RealTwoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RealTwoTextBox.Name = "RealTwoTextBox";
            this.RealTwoTextBox.Size = new System.Drawing.Size(132, 22);
            this.RealTwoTextBox.TabIndex = 1;
            // 
            // ImaginaryTwoTextBox
            // 
            this.ImaginaryTwoTextBox.Location = new System.Drawing.Point(111, 73);
            this.ImaginaryTwoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImaginaryTwoTextBox.Name = "ImaginaryTwoTextBox";
            this.ImaginaryTwoTextBox.Size = new System.Drawing.Size(132, 22);
            this.ImaginaryTwoTextBox.TabIndex = 3;
            // 
            // RealTwoLabel
            // 
            this.RealTwoLabel.AutoSize = true;
            this.RealTwoLabel.Location = new System.Drawing.Point(8, 44);
            this.RealTwoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RealTwoLabel.Name = "RealTwoLabel";
            this.RealTwoLabel.Size = new System.Drawing.Size(37, 17);
            this.RealTwoLabel.TabIndex = 0;
            this.RealTwoLabel.Text = "Real";
            // 
            // ImaginaryTwoLabel
            // 
            this.ImaginaryTwoLabel.AutoSize = true;
            this.ImaginaryTwoLabel.Location = new System.Drawing.Point(8, 76);
            this.ImaginaryTwoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImaginaryTwoLabel.Name = "ImaginaryTwoLabel";
            this.ImaginaryTwoLabel.Size = new System.Drawing.Size(69, 17);
            this.ImaginaryTwoLabel.TabIndex = 2;
            this.ImaginaryTwoLabel.Text = "Imaginary";
            // 
            // OperandOneGroupBox
            // 
            this.OperandOneGroupBox.Controls.Add(this.RealOneTextBox);
            this.OperandOneGroupBox.Controls.Add(this.ImaginaryOneTextBox);
            this.OperandOneGroupBox.Controls.Add(this.RealOneLabel);
            this.OperandOneGroupBox.Controls.Add(this.ImaginaryOneLabel);
            this.OperandOneGroupBox.Location = new System.Drawing.Point(23, 22);
            this.OperandOneGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.OperandOneGroupBox.Name = "OperandOneGroupBox";
            this.OperandOneGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.OperandOneGroupBox.Size = new System.Drawing.Size(267, 123);
            this.OperandOneGroupBox.TabIndex = 9;
            this.OperandOneGroupBox.TabStop = false;
            this.OperandOneGroupBox.Text = "Operand One";
            // 
            // RealOneTextBox
            // 
            this.RealOneTextBox.Location = new System.Drawing.Point(116, 41);
            this.RealOneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RealOneTextBox.Name = "RealOneTextBox";
            this.RealOneTextBox.Size = new System.Drawing.Size(132, 22);
            this.RealOneTextBox.TabIndex = 1;
            // 
            // ImaginaryOneTextBox
            // 
            this.ImaginaryOneTextBox.Location = new System.Drawing.Point(116, 73);
            this.ImaginaryOneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImaginaryOneTextBox.Name = "ImaginaryOneTextBox";
            this.ImaginaryOneTextBox.Size = new System.Drawing.Size(132, 22);
            this.ImaginaryOneTextBox.TabIndex = 3;
            // 
            // RealOneLabel
            // 
            this.RealOneLabel.AutoSize = true;
            this.RealOneLabel.Location = new System.Drawing.Point(8, 44);
            this.RealOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RealOneLabel.Name = "RealOneLabel";
            this.RealOneLabel.Size = new System.Drawing.Size(37, 17);
            this.RealOneLabel.TabIndex = 0;
            this.RealOneLabel.Text = "Real";
            // 
            // ImaginaryOneLabel
            // 
            this.ImaginaryOneLabel.AutoSize = true;
            this.ImaginaryOneLabel.Location = new System.Drawing.Point(8, 76);
            this.ImaginaryOneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImaginaryOneLabel.Name = "ImaginaryOneLabel";
            this.ImaginaryOneLabel.Size = new System.Drawing.Size(69, 17);
            this.ImaginaryOneLabel.TabIndex = 2;
            this.ImaginaryOneLabel.Text = "Imaginary";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 444);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.OperationsGroupBox);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.OperandTwoGroupBox);
            this.Controls.Add(this.OperandOneGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Complex Number Calculator";
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperandTwoGroupBox.ResumeLayout(false);
            this.OperandTwoGroupBox.PerformLayout();
            this.OperandOneGroupBox.ResumeLayout(false);
            this.OperandOneGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.Button NotEqualsButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.GroupBox OperandTwoGroupBox;
        private System.Windows.Forms.TextBox RealTwoTextBox;
        private System.Windows.Forms.TextBox ImaginaryTwoTextBox;
        private System.Windows.Forms.Label RealTwoLabel;
        private System.Windows.Forms.Label ImaginaryTwoLabel;
        private System.Windows.Forms.GroupBox OperandOneGroupBox;
        private System.Windows.Forms.TextBox RealOneTextBox;
        private System.Windows.Forms.TextBox ImaginaryOneTextBox;
        private System.Windows.Forms.Label RealOneLabel;
        private System.Windows.Forms.Label ImaginaryOneLabel;
    }
}

