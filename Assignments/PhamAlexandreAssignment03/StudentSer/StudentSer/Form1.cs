using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using StudentLibrary;

namespace StudentSer
{
    public partial class StudentGradeForm : StudentForm
    {
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private BinaryFormatter reader = new BinaryFormatter();
        private FileStream input;
        public StudentGradeForm()
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
                        output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

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
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account Number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
