﻿using System;
using System.Windows.Forms;

namespace Product_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.SearchDesc(
                this.productDataSet.Product,searchTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDataSet.Product);
        }
    }
}
