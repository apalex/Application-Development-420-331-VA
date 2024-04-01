namespace UsingMDI
{
    partial class ChildForm
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
            this.displayPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPictureBox
            // 
            this.displayPictureBox.Image = global::UsingMDI.Properties.Resources.yellowflowers;
            this.displayPictureBox.Location = new System.Drawing.Point(31, 42);
            this.displayPictureBox.Name = "displayPictureBox";
            this.displayPictureBox.Size = new System.Drawing.Size(472, 314);
            this.displayPictureBox.TabIndex = 0;
            this.displayPictureBox.TabStop = false;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 397);
            this.Controls.Add(this.displayPictureBox);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox displayPictureBox;
    }
}