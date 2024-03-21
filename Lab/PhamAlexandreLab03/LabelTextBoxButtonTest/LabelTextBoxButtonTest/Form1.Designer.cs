namespace LabelTextBoxButtonTest
{
    partial class LabelTextBoxButtonTestForm
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
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(119, 113);
            this.displayPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(89, 25);
            this.displayPasswordButton.TabIndex = 0;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.displayPasswordLabel.Location = new System.Drawing.Point(29, 83);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(289, 27);
            this.displayPasswordLabel.TabIndex = 1;
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(33, 45);
            this.inputPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.PasswordChar = '$';
            this.inputPasswordTextBox.Size = new System.Drawing.Size(286, 22);
            this.inputPasswordTextBox.TabIndex = 2;
            // 
            // LabelTextBoxButtonTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 147);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPasswordButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LabelTextBoxButtonTestForm";
            this.Text = "Label, TextBox and Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
    }
}

