﻿namespace CreditInquiry
{
    partial class CreditInquiryForm
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
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(12, 12);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(724, 143);
            this.displayTextBox.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 161);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(140, 32);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.Enabled = false;
            this.creditButton.Location = new System.Drawing.Point(158, 161);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(140, 32);
            this.creditButton.TabIndex = 2;
            this.creditButton.Text = "Credit Balances";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // debitButton
            // 
            this.debitButton.Enabled = false;
            this.debitButton.Location = new System.Drawing.Point(304, 161);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(140, 32);
            this.debitButton.TabIndex = 3;
            this.debitButton.Text = "Debit Balances";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Enabled = false;
            this.zeroButton.Location = new System.Drawing.Point(450, 161);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(140, 32);
            this.zeroButton.TabIndex = 4;
            this.zeroButton.Text = "Zero Balances";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(596, 161);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(140, 32);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CreditInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 214);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.displayTextBox);
            this.Name = "CreditInquiryForm";
            this.Text = "Credit Inquiry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button doneButton;
    }
}

