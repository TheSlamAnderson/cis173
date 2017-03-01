//****************************************************************************************************
// Program Name:    Chapter 3, Problem 3.5 Extra Credit
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

namespace Module3._
{
    public partial class Form1 : Form
    {

        // Declare Constants
        const Decimal DAILY_RATE_Decimal = 15.0m;
        const Decimal MILE_RATE_Decimal = 0.12m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            // Declare Variables
            decimal beginOdo;
            decimal endOdo;
            decimal noDays;
            decimal milesDriven;
            decimal totalCharge;

            try
            {

                // Convert Beginning Odometer Input Value To Numeric And Assign To Variable
                beginOdo = decimal.Parse(tbBeginOdo.Text);

                try
                {

                    // Convert Ending Odometer Input Value To Numeric And Assign To Variable
                    endOdo = decimal.Parse(tbEndOdo.Text);

                    try
                    {
                        // Convert Number of Days Input Value To Numeric And Assign To Variable
                        noDays = decimal.Parse(tbDays.Text);

                        try
                        {

                            // Calculate Miles Values
                            milesDriven = endOdo - beginOdo;
                            tbMiles.Text = milesDriven.ToString("N1");

                            // Calculate Charges Values
                            totalCharge = (milesDriven * MILE_RATE_Decimal) + (noDays * DAILY_RATE_Decimal);
                            tbTotal.Text = totalCharge.ToString("C");

                        }
                        catch
                        {
                            MessageBox.Show("Unknown Error In Calculation.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("The Number of Days must be a numeric value.", "Invalid Number Of Days", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("The Ending Odometer reading must be a numeric value.", "Invalid Ending Odometer Reading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("The Beginning Odometer reading must be a numeric value.","Invalid Beginning Odometer Reading",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear All Text Boxes
            tbName.Clear();
            tbAddress.Clear();
            tbCity.Clear();
            tbState.Clear();
            tbZip.Clear();
            tbBeginOdo.Clear();
            tbEndOdo.Clear();
            tbDays.Clear();
            tbMiles.Clear();
            tbTotal.Clear();

            // Focus On Name Text Box
            tbName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }
    }
}