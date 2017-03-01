//****************************************************************************************************
// Program Name:    Chapter 6 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            03.29.08
// Purpose:         Multiform Projects
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // MENU STRIP ITEMS

        private void inputSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare New Sales Form
            Sales aSalesForm = new Sales();

            // Display Sales Form
            aSalesForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit The Form
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog And Change Label Color
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
            label2.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog And Change Label Font
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            label2.Font = fontDialog1.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare New About Form
            About aboutForm = new About();

            // Display About Form
            aboutForm.Show();
        }
    }
}