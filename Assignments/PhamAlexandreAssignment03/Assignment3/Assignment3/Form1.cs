using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Assignment3
{
    public partial class StudentForm : Form
    {
        public enum TextBoxIndices { StudentID, LastName,FirstName,Course,Grade}
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;
        protected int TextBoxCount { get; set; } = 5;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                output?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.OpenOrCreate,FileAccess.Write);

                        saveButton.Enabled = false;
                        enterButton.Enabled = true;
                        loadButton.Enabled = false;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.StudentID]))
            {
                try
                {
                    int studentId = int.Parse(values[(int)TextBoxIndices.StudentID]);

                    if (studentId > 0)
                    {
                        var record = new Student(
                            studentId,
                            values[(int)TextBoxIndices.LastName],
                            values[(int)TextBoxIndices.FirstName],
                            values[(int)TextBoxIndices.Course],
                            values[(int)TextBoxIndices.Grade]
                            );

                        formatter.Serialize(output, record);
                        output.Flush();
                    } else
                    {
                        MessageBox.Show("Invalid Account Number", "Error",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Erorr Writing to File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearTextBoxes();
        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                studentIdTextBox.Text, lastNameTextBox.Text,
                firstNameTextBox.Text, courseTextBox.Text,
                gradeTextBox.Text
            };
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
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
                    input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    saveButton.Enabled = false;
                    enterButton.Enabled = false;

                    while (input.Position < input.Length)
                    {
                        Student student = (Student)reader.Deserialize(input);
                        displayTextBox.AppendText(student.ToString() + Environment.NewLine);
                    }
                }
            }
        }
    }
}
