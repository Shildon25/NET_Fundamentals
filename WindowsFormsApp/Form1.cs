using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelloLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "")
            {
                lblHello.Text = ConcatDate.AddDate($"Hello, {textBoxUsername.Text}");
            }
            else
            {
                lblHello.Text = "Please, enter username";
            }
            lblHello.Visible = true;
        }
    }
}
