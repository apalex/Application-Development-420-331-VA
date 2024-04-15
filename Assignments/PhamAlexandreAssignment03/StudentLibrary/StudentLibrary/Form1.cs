using System;
using System.Windows.Forms;

namespace StudentLibrary
{
    public partial class StudentForm : Form
    {
        protected int TextBoxCount { get; set; } = 5;
        public enum TextBoxIndices { StudentID, LastName, FirstName, Course, Grade }

        public StudentForm()
        {
            InitializeComponent();
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
    }
}
