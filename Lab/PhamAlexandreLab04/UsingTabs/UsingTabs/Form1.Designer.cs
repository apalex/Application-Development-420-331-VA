namespace UsingTabs
{
    partial class UsingTabsForm
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.colorPage = new System.Windows.Forms.TabPage();
            this.sizePage = new System.Windows.Forms.TabPage();
            this.messagePage = new System.Windows.Forms.TabPage();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.displayLabel = new System.Windows.Forms.Label();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage.SuspendLayout();
            this.colorPage.SuspendLayout();
            this.sizePage.SuspendLayout();
            this.messagePage.SuspendLayout();
            this.aboutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.colorPage);
            this.tabPage.Controls.Add(this.sizePage);
            this.tabPage.Controls.Add(this.messagePage);
            this.tabPage.Controls.Add(this.aboutPage);
            this.tabPage.Location = new System.Drawing.Point(12, 12);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(286, 138);
            this.tabPage.TabIndex = 0;
            this.tabPage.Tag = "";
            // 
            // colorPage
            // 
            this.colorPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colorPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPage.Controls.Add(this.greenRadioButton);
            this.colorPage.Controls.Add(this.redRadioButton);
            this.colorPage.Controls.Add(this.blackRadioButton);
            this.colorPage.Location = new System.Drawing.Point(4, 29);
            this.colorPage.Name = "colorPage";
            this.colorPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorPage.Size = new System.Drawing.Size(278, 105);
            this.colorPage.TabIndex = 0;
            this.colorPage.Text = "Color";
            // 
            // sizePage
            // 
            this.sizePage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sizePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sizePage.Controls.Add(this.size20RadioButton);
            this.sizePage.Controls.Add(this.size16RadioButton);
            this.sizePage.Controls.Add(this.size12RadioButton);
            this.sizePage.Location = new System.Drawing.Point(4, 29);
            this.sizePage.Name = "sizePage";
            this.sizePage.Padding = new System.Windows.Forms.Padding(3);
            this.sizePage.Size = new System.Drawing.Size(278, 105);
            this.sizePage.TabIndex = 1;
            this.sizePage.Text = "Size";
            // 
            // messagePage
            // 
            this.messagePage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messagePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePage.Controls.Add(this.goodbyeRadioButton);
            this.messagePage.Controls.Add(this.helloRadioButton);
            this.messagePage.Location = new System.Drawing.Point(4, 29);
            this.messagePage.Name = "messagePage";
            this.messagePage.Padding = new System.Windows.Forms.Padding(3);
            this.messagePage.Size = new System.Drawing.Size(278, 105);
            this.messagePage.TabIndex = 2;
            this.messagePage.Text = "Message";
            // 
            // aboutPage
            // 
            this.aboutPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aboutPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboutPage.Controls.Add(this.label1);
            this.aboutPage.Location = new System.Drawing.Point(4, 29);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutPage.Size = new System.Drawing.Size(278, 105);
            this.aboutPage.TabIndex = 3;
            this.aboutPage.Text = "About";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(73, 24);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(6, 36);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(64, 24);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(6, 66);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(79, 24);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(105, 177);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(76, 29);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Hello!";
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Location = new System.Drawing.Point(6, 6);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(91, 24);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(6, 36);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(91, 24);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(6, 66);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(91, 24);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Location = new System.Drawing.Point(6, 6);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.Size = new System.Drawing.Size(74, 24);
            this.helloRadioButton.TabIndex = 0;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.UseVisualStyleBackColor = true;
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Location = new System.Drawing.Point(6, 36);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(103, 24);
            this.goodbyeRadioButton.TabIndex = 1;
            this.goodbyeRadioButton.TabStop = true;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.UseVisualStyleBackColor = true;
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabs are used to organize controls and conserve screen space.";
            // 
            // UsingTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 239);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabPage);
            this.Name = "UsingTabsForm";
            this.Text = "Using Tabs";
            this.tabPage.ResumeLayout(false);
            this.colorPage.ResumeLayout(false);
            this.colorPage.PerformLayout();
            this.sizePage.ResumeLayout(false);
            this.sizePage.PerformLayout();
            this.messagePage.ResumeLayout(false);
            this.messagePage.PerformLayout();
            this.aboutPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage colorPage;
        private System.Windows.Forms.TabPage sizePage;
        private System.Windows.Forms.TabPage messagePage;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.Label label1;
    }
}

