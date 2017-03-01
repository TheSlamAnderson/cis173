//****************************************************************************************************
// Program Name:    Chapter 3 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            02.11.08
// Purpose:         This program demonstrates caluclations and variables
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module3
{
    public partial class Module3 : Form
    {
        // Declare The Constant And Answer Variables
        const decimal COMMISSION_RATE_Decimal = 0.2m;
        decimal commissionDecimal;

        public Module3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            // Declare Variables
            decimal sellingPriceDecimal;
            decimal costValueDecimal;

            try
            {
                // Convert Selling Price To Numeric And Assign To Variable
                sellingPriceDecimal = decimal.Parse(tbPrice.Text);

                try
                {
                    // Convert Cost Value To Numeric And Assign To Variable
                    costValueDecimal = decimal.Parse(tbValue.Text);

                    // Caluclate Values
                    commissionDecimal = COMMISSION_RATE_Decimal * (sellingPriceDecimal - costValueDecimal);

                    // Format And Display Answer
                    tbCommission.Text = commissionDecimal.ToString("C");
                }
                catch
                {
                    // Invalid Cost Value
                    MessageBox.Show("Please check your Cost Value and try again.  Cost Value must be a numeric value.", "Invalid Cost Value",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbValue.Focus();
                    tbValue.SelectAll();
                }
            }
            catch
            {
                // Invalid Selling Price
                MessageBox.Show("Please check your Selling Price and try again. Selling Price must be a numeric value.", "Invalid Selling Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Focus();
                tbPrice.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Text Boxes
            tbName.Clear();
            tbPrice.Clear();
            tbValue.Clear();
            tbCommission.Clear();
            tbName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // End The Program
            this.Close();
        }
    }
}