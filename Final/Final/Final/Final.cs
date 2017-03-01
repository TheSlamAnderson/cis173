//****************************************************************************************************
// Program Name:    FINAL EXAM, Smoothie Queen
// Programmer:      Christopher M. Anderson
// Date:            04.28.08
// Purpose:         FINAL EXAM
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class Final : Form
    {
        // Declare Boolean For Text Boxes
        bool booleanTextData = false;

        // Declare SubTotal Variable For Calculations
        decimal decimalSubTotal = 0m;

        // Declare Smoothie Variable
        decimal decimalSmoothie = 0m;

        // Declare Extras Constant
        const decimal CONST_Extras = 0.75m;

        // Declare Extras Variable
        decimal decimalExtras = 0m;

        // Declare Discount Constants
        const decimal CONST_Coupon = 0.10m;
        const decimal CONST_Customer = 0.15m;

        // Declare Discount Variable
        decimal decimalDiscount = 0m;

        // Declare Sales Tax Constant
        const decimal CONST_SalesTax = 0.08m;

        // Declare Sales Tax Variable
        decimal decimalSalesTax = 0m;

        // Declare Amount Due Variable
        decimal decimalAmountDue = 0m;

        public Final()
        {
            InitializeComponent();
        }

        // MENU BAR BUTTONS

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textData();

            if (booleanTextData == true)
            {
                // Reset Subtotal
                decimalSubTotal = 0m;

                // Calculate Price From Size And Style
                findSmoothie();
                decimalSubTotal += decimalSmoothie;

                // Display Price Of Smoothie
                tbSmoothie.Text = decimalSmoothie.ToString("C");

                // Calculate Extras
                findExtras();
                decimalSubTotal += decimalExtras;

                // Display Price Of Extras
                tbExtras.Text = decimalExtras.ToString("C");

                // Calculate Discount
                findDiscount(decimalSubTotal);
                decimalSubTotal -= decimalDiscount;

                // Display Amount Of Discount
                tbDisc.Text = decimalDiscount.ToString("C");

                // Calculate Sales Tax
                decimalSalesTax = decimalSubTotal * CONST_SalesTax;
                decimalAmountDue = decimalSubTotal + decimalSalesTax;

                // Display Sales Tax
                tbTax.Text = decimalSalesTax.ToString("C");

                // Display Amount Due
                tbDue.Text = decimalAmountDue.ToString("C");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear Customer Information
            tbName.Clear();
            tbAddress.Clear();
            tbCity.Clear();
            tbState.Clear();
            tbZip.Clear();

            // Clear Product
            ddSize.SelectedIndex = -1;
            ddSize.Text = "Select Smoothie Size:";
            ddStyle.SelectedIndex = -1;
            ddStyle.Text = "Select Smoothie Style:";

            // Clear Extras
            cbExtra1.Checked = false;
            cbExtra2.Checked = false;
            cbExtra3.Checked = false;

            // Clear Discount
            rbDisc1.Checked = true;

            // Reset Prices To Zero
            string defString = "$0.00";
            tbSmoothie.Text = defString;
            tbExtras.Text = defString;
            tbDisc.Text = defString;
            tbTax.Text = defString;
            tbDue.Text = defString;

            // Reset Colors To Black
            gbCustomerInfo.ForeColor = Color.Black;
            gbProduct.ForeColor = Color.Black;
            gbExtras.ForeColor = Color.Black;
            gbDiscount.ForeColor = Color.Black;
            gbPricing.ForeColor = Color.Black;

            // Reset Font Back To Default
            gbCustomerInfo.Font = new Font("Tahoma", 10, FontStyle.Bold);
            gbProduct.Font = new Font("Tahoma", 10, FontStyle.Bold);
            gbExtras.Font = new Font("Tahoma", 10, FontStyle.Bold);
            gbDiscount.Font = new Font("Tahoma", 10, FontStyle.Bold);
            gbPricing.Font = new Font("Tahoma", 10, FontStyle.Bold);

            // Reset Focus To Customer Name
            tbName.Focus();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Print For Extra Credit
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize The Font Dialog Box
            fontDialog1.ShowDialog();

            // Assign The New Font To Group Boxes
            gbCustomerInfo.Font = fontDialog1.Font;
            gbProduct.Font = fontDialog1.Font;
            gbExtras.Font = fontDialog1.Font;
            gbDiscount.Font = fontDialog1.Font;
            gbPricing.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize The Color Dialog Box
            colorDialog1.ShowDialog();

            // Assign The New Color To Group Boxes
            gbCustomerInfo.ForeColor = colorDialog1.Color;
            gbProduct.ForeColor = colorDialog1.Color;
            gbExtras.ForeColor = colorDialog1.Color;
            gbDiscount.ForeColor = colorDialog1.Color;
            gbPricing.ForeColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string messageString = "Smoothie Queen" + "\n" + "Christopher M. Anderson" + "\n\n" + "Programming in C#" + "\n" + "Final Exam" + "\n" + "April 2008";
            MessageBox.Show(messageString, "About This Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool textData()
        {
            // Validate That All Text Fields Have Data
            if (tbName.Text == "")
            {
                MessageBox.Show("Please enter the customer name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                booleanTextData = false;
            }
            else if (tbAddress.Text == "")
            {
                MessageBox.Show("Please enter the street address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                booleanTextData = false;
            }
            else if (tbCity.Text == "")
            {
                MessageBox.Show("Please enter the city.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                booleanTextData = false;
            }
            else if (tbState.Text == "")
            {
                MessageBox.Show("Please enter the state.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                booleanTextData = false;
            }
            else if (tbZip.Text == "")
            {
                MessageBox.Show("Please enter the zip code.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                booleanTextData = false;
            }
            else
            {
                booleanTextData = true;
            }

            // Return Boolean For Text Data
            return booleanTextData;
        }

        private decimal findSmoothie()
        {
            // Declare Smoothie Array
            decimal[,] decimalSmoothieArray = 
            {
                { 5.99M, 6.99M, 7.99M, 8.99M }, 
                { 6.99M, 7.99M, 8.99M, 9.99M }
            };

            // Get Size And Style From Drop Downs
            int integerSize = ddSize.SelectedIndex;
            int integerStyle = ddStyle.SelectedIndex;

            // Validate Drop Downs Chosen
            if (integerSize < 0)
            {
                MessageBox.Show("Please select a Smoothie size.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (integerStyle < 0)
            {
                MessageBox.Show("Please select a Smoothie style.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Find Smoothie Price From Array
                decimalSmoothie = decimalSmoothieArray[integerStyle, integerSize];
            }

            // Return Smoothie Value
            return decimalSmoothie;
        }

        private decimal findExtras()
        {
            // Reset To Zero
            decimalExtras = 0m;

            // Calculate Extras Value
            if (cbExtra1.Checked)
                decimalExtras += CONST_Extras;
            if (cbExtra2.Checked)
                decimalExtras += CONST_Extras;
            if (cbExtra3.Checked)
                decimalExtras += CONST_Extras;
            
            // Return Extras Value
            return decimalExtras;
        }

        private decimal findDiscount(decimal decimalSubTotal)
        {
            // Reset To Zero
            decimalDiscount = 0m;
            
            // Calculate Discount Value
            if (rbDisc1.Checked)
                decimalDiscount = 0;
            if (rbDisc2.Checked)
                decimalDiscount = decimalSubTotal * CONST_Coupon;
            if (rbDisc3.Checked)
                decimalDiscount = decimalSubTotal * CONST_Customer;

            // Return Discount Value
            return decimalDiscount;
        }
    }
}