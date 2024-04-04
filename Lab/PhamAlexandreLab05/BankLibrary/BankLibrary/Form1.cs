﻿using System;
using System.Windows.Forms;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;
        public enum TextBoxIndices { Account, First, Last, Balance }
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException(
                    $"There must be {TextBoxCount} strings in the array",
                    nameof(values)));
            } else
            {
                accountTextBox.Text = values[(int)TextBoxIndices.Account];
                firstNameTextBox.Text = values[(int)TextBoxIndices.First];
                lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
                balanceTextBox.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                accountTextBox.Text, firstNameTextBox.Text,
                lastNameTextBox.Text, balanceTextBox.Text
            };
        }

    }
}
