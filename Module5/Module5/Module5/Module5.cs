//****************************************************************************************************
// Program Name:    Chapter 5 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            03.17.08
// Purpose:         Menus, Common Dialog Boxes, and Methods
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module5
{
    public partial class Module5 : Form
    {
        public Module5()
        {
            InitializeComponent();
        }

        private void Module5_Load(object sender, EventArgs e)
        {

        }

        // MENU STRIP ITEMS

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Run Exit Method
            exitProgram();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Run Calculation Method
            calcProgram();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Run Clear Method
            clearProgram();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog And Change Amount Due Font
            fontDialog1.ShowDialog();
            tbAmtDue.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog And Change Form Fore Color
            colorDialog1.ShowDialog();
            lblPrice.ForeColor = colorDialog1.Color;
            lblFinish.ForeColor = colorDialog1.Color;
            tbFinish.ForeColor = colorDialog1.Color;
            lblTax.ForeColor = colorDialog1.Color;
            lblSubtotal.ForeColor = colorDialog1.Color;
            lblTotal.ForeColor = colorDialog1.Color;
            lblTrade.ForeColor = colorDialog1.Color;
            lblAmtDue.ForeColor = colorDialog1.Color;
            gbAccessories.ForeColor = colorDialog1.Color;
            gbExterior.ForeColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display About Message Box
            string messageString = "Christopher's Car Center" + "\n" + "Programmed By Christopher Anderson";
            MessageBox.Show(messageString,"About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // BUTTON ITEMS

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calcProgram();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearProgram();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgram();
        }

        // METHODS

        private void calcProgram()
        {

            // Declare Variables
            decimal decFinish = 0;
            decimal decSubtotal = 0;
            decimal decTax = 0;
            decimal decTotal = 0;
            decimal decTrade;
            decimal decAmtDue = 0;

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
                decTax = calcSalesTax(decSubtotal);
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
                MessageBox.Show(errorString, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal calcSalesTax(decimal decSubtotal)
        {

            // Declare Sales Tax
            const decimal DEC_SALES_TAX = 0.08m;

            // Calculate Sales Tax
            return (decSubtotal * DEC_SALES_TAX);

        }

        private void clearProgram()
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

            // Reset Amount Due Font
            tbAmtDue.Font = new Font("Tahoma", 12, FontStyle.Bold);

            // Reset Form Fore Color
            lblPrice.ForeColor = Color.Black;
            lblFinish.ForeColor = Color.Black;
            lblTax.ForeColor = Color.Black;
            lblSubtotal.ForeColor = Color.Black;
            lblTotal.ForeColor = Color.Black;
            lblTrade.ForeColor = Color.Black;
            lblAmtDue.ForeColor = Color.Black;
            gbAccessories.ForeColor = Color.Black;
            gbExterior.ForeColor = Color.Black;

            // Focus On Sales Price
            tbPrice.Focus();
        }

        private void exitProgram()
        {
            // Exit The Program
            this.Close();
        }
    }
}