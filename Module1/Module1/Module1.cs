using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module1
{
    public partial class Module1 : Form
    {
        public Module1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Family wagon, immaculate condition $12,995";
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Lube, oil, filter $25.99";
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Complete detail $79.95 for most cars";
        }

        private void btnEmployment_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Sales position, contact Mr. Mann 551-2134 x475";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}