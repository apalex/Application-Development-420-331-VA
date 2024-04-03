using System;
using System.Windows.Forms;

namespace ClockExample
{
    public partial class ClockUserControl : UserControl
    {
        public ClockUserControl()
        {
            InitializeComponent();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
