namespace VisualInheritanceBase
{
    partial class VisualInheritanceBaseForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button learnMoreButton;
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            learnMoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugs, Bugs, Bugs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label2.CausesValidation = false;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 221);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(379, 27);
            label2.TabIndex = 1;
            label2.Text = "Copyright 2017, by Deitel & Associates, Inc.";
            // 
            // learnMoreButton
            // 
            learnMoreButton.BackColor = System.Drawing.Color.Silver;
            learnMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            learnMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            learnMoreButton.Location = new System.Drawing.Point(12, 130);
            learnMoreButton.Name = "learnMoreButton";
            learnMoreButton.Size = new System.Drawing.Size(194, 74);
            learnMoreButton.TabIndex = 2;
            learnMoreButton.Text = "Learn More";
            learnMoreButton.UseVisualStyleBackColor = false;
            learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
            // 
            // VisualInheritanceBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(427, 275);
            this.Controls.Add(learnMoreButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Name = "VisualInheritanceBaseForm";
            this.ShowIcon = false;
            this.Text = "Visual Inheritance Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

