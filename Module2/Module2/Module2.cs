//****************************************************************************************************
// Program Name:    Chapter 2 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            02.04.08
// Purpose:         This program demonstrates picture boxes, ToolTips, radio buttons, and a checkbox
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module2
{
    public partial class Module2 : Form
    {
        public Module2()
        {
            InitializeComponent();

            // Hours Hidden When Program Starts
            lblHours.Visible = false;
        }

        private void cbHours_CheckedChanged(object sender, EventArgs e)
        {
            // Display Hours If Checked
            lblHours.Visible = cbHours.Checked;
        }

        private void pbSales_Click(object sender, EventArgs e)
        {
            // Display Sales Information
            lblMessage.Text = "Family wagon, immaculate condition $12,995";
        }

        private void pbService_Click(object sender, EventArgs e)
        {
            // Display Service Information
            lblMessage.Text = "Lube, oil, filter $25.99";
        }

        private void pcDetail_Click(object sender, EventArgs e)
        {
            // Display Detail Shop Information
            lblMessage.Text = "Complete detail $79.95 for most cars";
        }

        private void pbEmployment_Click(object sender, EventArgs e)
        {
            // Display Employment Information
            lblMessage.Text = "Sales position, contact Mr. Mann 551-2134 x475";
        }

        private void rbGrey_CheckedChanged(object sender, EventArgs e)
        {
            // Set Background Color And Text Color
            lblMessage.BackColor = SystemColors.Control;
            lblMessage.ForeColor = SystemColors.ControlText;
        }
        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            // Set Background Color And Text Color
            lblMessage.BackColor = Color.Red;
            lblMessage.ForeColor = Color.White;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            // Set Background Color And Text Color
            lblMessage.BackColor = Color.Green;
            lblMessage.ForeColor = Color.White;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            // Set Background Color And Text Color
            lblMessage.BackColor = Color.Blue;
            lblMessage.ForeColor = Color.White;
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            // Clear Message And Reset Colors
            lblMessage.Text = "";
            rbGrey.Checked = true;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }
    }
}