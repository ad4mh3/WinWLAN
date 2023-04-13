using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWLAN.UX
{
    public partial class IntegerInputWindow : Form
    {
        public int result = 0;
        
        public IntegerInputWindow(string request, int minimum , int maximum, int defaultValue = 0)
        {
            InitializeComponent();
            this.Requesttxt.Text = request;
            this.valueAdjustment.Minimum = minimum;
            this.valueAdjustment.Maximum = maximum;
            this.valueAdjustment.Value = defaultValue;
        }

        private void valueAdjustment_ValueChanged(object sender, EventArgs e)
        {
            this.currentValueTxt.Text = this.valueAdjustment.Value.ToString();    
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            result = this.valueAdjustment.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
