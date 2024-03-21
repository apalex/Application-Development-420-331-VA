namespace NumericUpDownTest
{
    partial class InterestCalculatorForm
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
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelYears = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipal.Location = new System.Drawing.Point(57, 22);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(79, 20);
            this.labelPrincipal.TabIndex = 0;
            this.labelPrincipal.Text = "Principal:";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInterestRate.Location = new System.Drawing.Point(26, 58);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(110, 20);
            this.labelInterestRate.TabIndex = 1;
            this.labelInterestRate.Text = "Interest Rate:";
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYears.Location = new System.Drawing.Point(79, 94);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(57, 20);
            this.labelYears.TabIndex = 2;
            this.labelYears.Text = "Years:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(201, 19);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(119, 22);
            this.principalTextBox.TabIndex = 3;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(201, 58);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(119, 22);
            this.interestTextBox.TabIndex = 4;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.yearUpDown.Location = new System.Drawing.Point(201, 94);
            this.yearUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(120, 22);
            this.yearUpDown.TabIndex = 5;
            this.yearUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(335, 19);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yearly account balance:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.Location = new System.Drawing.Point(33, 171);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(396, 168);
            this.displayTextBox.TabIndex = 8;
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 351);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelPrincipal);
            this.Name = "InterestCalculatorForm";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

