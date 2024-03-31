﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComboBoxTest
{
    public partial class ComBoxTestForm : Form
    {
        public ComBoxTestForm()
        {
            InitializeComponent();
        }

        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Graphics myGraphics = base.CreateGraphics())

            using (Pen myPen = new Pen(Color.DarkRed))

            using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed))
            {
                myGraphics.Clear(Color.White);
                switch (imageComboBox.SelectedIndex)
                {
                    case 0:
                        myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                        break;
                    case 1:
                        myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                        break;
                    case 2:
                        myGraphics.DrawEllipse(myPen, 50, 85, 150, 115);
                        break;
                    case 3:
                        myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                        break;
                    case 4:
                        myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                        break;
                    case 5:
                        myGraphics.FillRectangle(
                        mySolidBrush, 50, 50, 150, 150);
                        break;
                    case 6:
                        myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                        break;
                    case 7:
                        myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45);
                        break;
                }
            }
        }
    }
}
