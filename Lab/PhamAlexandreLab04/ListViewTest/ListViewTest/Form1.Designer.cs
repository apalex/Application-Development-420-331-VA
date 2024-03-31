namespace ListViewTest
{
    partial class ListViewTestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewTestForm));
            this.displayLabel = new System.Windows.Forms.Label();
            this.browserListView = new System.Windows.Forms.ListView();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            resources.ApplyResources(this.displayLabel, "displayLabel");
            this.displayLabel.Name = "displayLabel";
            // 
            // browserListView
            // 
            this.browserListView.HideSelection = false;
            this.browserListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("browserListView.Items")))});
            resources.ApplyResources(this.browserListView, "browserListView");
            this.browserListView.Name = "browserListView";
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.View = System.Windows.Forms.View.SmallIcon;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileFolderImageList.ImageStream")));
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileFolderImageList.Images.SetKeyName(0, "file.bmp");
            this.fileFolderImageList.Images.SetKeyName(1, "folder.bmp");
            // 
            // ListViewTestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browserListView);
            this.Controls.Add(this.displayLabel);
            this.Name = "ListViewTestForm";
            this.Load += new System.EventHandler(this.ListViewTestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.ImageList fileFolderImageList;
    }
}

