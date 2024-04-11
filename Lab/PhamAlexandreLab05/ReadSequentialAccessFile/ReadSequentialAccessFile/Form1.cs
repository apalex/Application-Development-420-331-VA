using System;
using System;
using System.Windows.Forms;
using System.IO;
using BankLibrary;

namespace ReadSequentialAccessFile
{
    public partial class ReadSequentialAccessFileForm : BankUIForm
    {
        private StreamReader fileReader;
        public ReadSequentialAccessFileForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                ClearTextBoxes();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        fileReader = new StreamReader(input);

                        openButton.Enabled = false;
                        nextButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file",
                            "File Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();

                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');

                    SetTextBoxValues(inputFields);
                }
                else
                {
                    fileReader.Close();
                    openButton.Enabled = true;
                    nextButton.Enabled = false;
                    ClearTextBoxes() ;

                    MessageBox.Show("No more records in file", string.Empty,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Reading from File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
