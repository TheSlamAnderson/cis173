//****************************************************************************************************
// Program Name:    Chapter 4 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            02.23.08
// Purpose:         Decisions and Conditions
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module4
{
    public partial class Module4 : Form
    {
        public Module4()
        {
            InitializeComponent();
        }

        private void Module4_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare Variables
            decimal decFinish = 0;
            decimal decSubtotal = 0;
            decimal decTax = 0;
            decimal decTotal = 0;
            decimal decTrade;
            decimal decAmtDue = 0;

            // Declare Sales Tax
            const decimal DEC_SALES_TAX = 0.08m;

            try
            {
                // Get Price From Text Box
                decimal decPrice = decimal.Parse(tbPrice.Text);
                
                // Display Price
                tbPrice.Text = decPrice.ToString("N");

                // Stereo System Check Box
                if (cbStereo.Checked)
                {
                    decFinish += 425.76m;
                }

                // Leather Interior Check Box
                if (cbLeather.Checked)
                {
                    decFinish += 987.41m;
                }

                // Computer Navigation Check Box
                if (cbComputer.Checked)
                {
                    decFinish += 1741.23m;
                }

                // Calculate Exterior Finish
                if (rbStandard.Checked)
                {
                    decFinish += 0m;
                }
                else if (rbPearlized.Checked)
                {
                    decFinish += 345.72m;
                }
                else if (rbDetailing.Checked)
                {
                    decFinish += 599.99m;
                }
                
                // Display Accessories & Finish
                tbFinish.Text = decFinish.ToString("N");

                // Display Subtotal
                decSubtotal = decPrice + decFinish;
                tbSubtotal.Text = decSubtotal.ToString("N");

                // Calculate Sales Tax
                decTax = decSubtotal * DEC_SALES_TAX;
                tbTax.Text = decTax.ToString("N");

                // Calculate Total
                decTotal = decSubtotal + decTax;
                tbTotal.Text = decTotal.ToString("N");

                // Calculate Trade In
                try
                {
                    decTrade = decimal.Parse(tbTrade.Text);
                }
                catch
                {
                    decTrade = 0;
                }

                // Display Trade In Amount
                tbTrade.Text = decTrade.ToString("N");

                // Display Amount Due
                decAmtDue = decTotal - decTrade;
                tbAmtDue.Text = decAmtDue.ToString("C");

            }
            catch
            {
                string errorString = "Please enter a Car Sales Price." + "\n\n" + "The price must be numeric and cannot contain a $ sign.";
                MessageBox.Show(errorString,"Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear All Checkboxes
            cbStereo.Checked = false;
            cbLeather.Checked = false;
            cbComputer.Checked = false;

            // Clear All Radios
            rbStandard.Checked = true;

            // Clear All Text Boxes
            tbPrice.Clear();
            tbFinish.Clear();
            tbSubtotal.Clear();
            tbTax.Clear();
            tbTotal.Clear();
            tbTrade.Clear();
            tbAmtDue.Clear();

            // Focus On Sales Price
            tbPrice.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }
    }
}