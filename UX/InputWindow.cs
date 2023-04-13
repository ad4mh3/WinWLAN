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
    public partial class InputWindow : Form
    {
        public string result = "";
        
        public InputWindow(string request)
        {
            InitializeComponent();
            this.Requesttxt.Text = request;   
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            result = this.txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
