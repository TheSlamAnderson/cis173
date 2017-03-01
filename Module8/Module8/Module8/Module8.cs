//****************************************************************************************************
// Program Name:    Chapter 8 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            04.20.08
// Purpose:         Arrays
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module8
{
    public partial class Module8 : Form
    {
        public Module8()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // Declare Entered Part Number
            String partNumberString = tbPartNumber.Text;

            // Verify That Brand Is Chosen
            if (rbClear.Checked)
            {
                MessageBox.Show("Please select a brand.", "CCC Parts Lookup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verify That Part Number Is Entered
                if (partNumberString == "")
                {
                    MessageBox.Show("Please enter the part number.", "CCC Parts Lookup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Declare Variables
                    int radioChoice = -1;               // Declare Radio Choice
                    int indexInteger = 0;               // Declare Index
                    int partRow = -1;                   // Declare Part Row
                    bool partFoundBoolean = false;      // Declare If Part Found Or Not

                    // Determine Which Brand
                    if (rbBrandA.Checked)
                    {
                        radioChoice = 1;
                    }
                    if (rbBrandC.Checked)
                    {
                        radioChoice = 2;
                    }
                    if (rbBrandX.Checked)
                    {
                        radioChoice = 3;
                    }

                    // Declare The Two-Dimensional Array
                    string[,] partString = new string[,]
                    {
                        {"PR214", "MR43T", "RBL8",    "14K22"},
                        {"PR223", "R43",   "RJ6",     "14K24"},
                        {"PR224", "R43N",  "RN4",     "14K30"},
                        {"PR246", "R46N",  "RN8",     "14K32"},
                        {"PR247", "R46TS", "RBL17Y",  "14K33"},
                        {"PR248", "R46TX", "RBL12-6", "14K35"},
                        {"PR324", "S46",   "J11",     "14K38"},
                        {"PR326", "SR46E", "XEJ8",    "14K40"},
                        {"PR444", "47L",   "H12",     "14K44"},
                    };               
                    
                    // Look Up Their Part Number To Find Out Part Row
                    while (!partFoundBoolean && indexInteger < 9)
                    {
                        if (partNumberString.ToUpper() == partString[indexInteger, radioChoice])
                        {
                            partRow = indexInteger;
                            partFoundBoolean = true;
                        }

                        indexInteger++;
                    }

                    // Display Results If Found Or Error If Not
                    if (partFoundBoolean)
                    {
                        tbCCCPart.Text = partString[partRow, 0];
                    }
                    else
                    {
                        MessageBox.Show("Invalid part number.", "CCC Parts Lookup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear The Form
            rbClear.Checked = true;
            tbPartNumber.Clear();
            tbCCCPart.Clear();

            // Set Focus
            tbPartNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }
    }
}