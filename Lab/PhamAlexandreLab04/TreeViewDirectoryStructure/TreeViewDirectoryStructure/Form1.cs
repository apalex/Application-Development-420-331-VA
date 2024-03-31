using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TreeViewDirectoryStructure
{
    public partial class TreeViewDirectoryStructureForm : Form
    {
        string substringDirectory;
        public TreeViewDirectoryStructureForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);
            
            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        substringDirectory = Path.GetFileNameWithoutExtension(directory);
                        TreeNode myNode = new TreeNode(substringDirectory);
                        parentNode.Nodes.Add(myNode);
                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            directoryTreeView.Nodes.Clear();

            if (Directory.Exists(inputTextBox.Text))
            {
                directoryTreeView.Nodes.Add(inputTextBox.Text);
                PopulateTreeView(inputTextBox.Text, directoryTreeView.Nodes[0]);
            }
            else
            {
                MessageBox.Show(inputTextBox.Text + " could not found be found.",
                    "Directory Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
