//****************************************************************************************************
// Program Name:    Chapter 5 Extra Credit, Sales Commission Calculator
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

namespace Module5_3
{
    public partial class Module5_3 : Form
    {

        // Declare Constants
        const decimal QUOTA_Decimal = 1000m;
        const decimal COMM_RATE_Decimal = 0.15m;
        const decimal BASE_RATE_Decimal = 250m;

        // Declare Variable
        decimal totalSales = 0;
        decimal totalComm = 0;
        decimal totalPay = 0;
        
        // Initialize Public Module
        public Module5_3()
        {
            InitializeComponent();
        }

        // MENU STRIP ITEMS

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Run Pay Calculation Method
            payCalc();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (totalSales <= 0)
            {
                MessageBox.Show("There Is No Data To Summarize.", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Display Summary Information
                string strSales = "Total Sales:              " + totalSales.ToString("C") + "\n";
                string strComm = "Total Commissions:  " + totalComm.ToString("C") + "\n";
                string strPay = "Total Pay:                " + totalPay.ToString("C");
                string messageString = strSales + "\n" + strComm + "\n" + strPay;
                MessageBox.Show(messageString, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear All Text Boxes
            tbName.Clear();
            tbSales.Clear();
            tbPay.Clear();
            tbCommission.Clear();

            // Set Objects To Default Color
            lblName.ForeColor = Color.Black;
            lblSales.ForeColor = Color.Black;
            lblPay.ForeColor = Color.Black;
            lblCommission.ForeColor = Color.Black;

            // Set Output To Default Font
            tbPay.Font = new Font("Tahoma", 10, FontStyle.Bold);
            tbCommission.Font = new Font("Tahoma", 10, FontStyle.Bold);

            // Focus On Name Box
            tbName.Focus();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display Font Dialog
            fontDialog1.ShowDialog();

            // Set Output To Selected Font
            tbPay.Font = fontDialog1.Font;
            tbCommission.Font = fontDialog1.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display Color Dialog
            colorDialog1.ShowDialog();

            // Set Objects To Selected Color
            lblName.ForeColor = colorDialog1.Color;
            lblSales.ForeColor = colorDialog1.Color;
            lblPay.ForeColor = colorDialog1.Color;
            lblCommission.ForeColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display About Message Box
            string messageString = "Commission Calculator" + "\n" + "Programmed By: Christopher Anderson";
            MessageBox.Show(messageString, "About The Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // METHODS

        private void payCalc()
        {
            try
            {

                // Declare And Get Sales Price
                decimal salesAmt = decimal.Parse(tbSales.Text);

                if (salesAmt <= 0)
                {
                    // Display Error If Less Or Equal To 0
                    MessageBox.Show("Please Enter A Valid Numeric Sales Amount.", "Sales Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Declare Pay And Add Base Rate
                    decimal payAmt = BASE_RATE_Decimal;

                    // Add Sales Price To Total
                    totalSales += salesAmt;

                    // Determine If Quota Met
                    if (salesAmt >= QUOTA_Decimal)
                    {
                        // Declare And Calculate Commission
                        decimal commAmt = salesAmt * COMM_RATE_Decimal;

                        // Add Commission To Total
                        totalComm += commAmt;

                        // Display Commission Amount
                        tbCommission.Text = commAmt.ToString("N");

                        // Add Commission To Total Pay
                        payAmt += commAmt;

                    }
                    else
                    {
                        // Clear Commision If 0
                        tbCommission.Text = "";
                    }

                    // Add Pay To Total
                    totalPay += payAmt;
                    
                    // Display Total Pay
                    tbPay.Text = payAmt.ToString("N");
                }
            }
            catch
            {
                // Display Error Message If No Sales Amount
                MessageBox.Show("Please Enter A Valid Numeric Sales Amount.", "Sales Amount Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbSales.Focus();
            }
        }
    }
}