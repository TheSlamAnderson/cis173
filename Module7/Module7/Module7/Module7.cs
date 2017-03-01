//****************************************************************************************************
// Program Name:    Chapter 6 Case Study, Christopher's Car Center
// Programmer:      Christopher M. Anderson
// Date:            04.07.08
// Purpose:         Lists, Loops, and Printing
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module7
{
    public partial class Module7 : Form
    {

        // Declare Exterior Constants
        const string SELECT_Hand_Wash = "Hand Wash";
        const string SELECT_Hand_Wax = "Hand Wax";
        const string SELECT_Check_Fluid = "Check Engine Fluids";
        const string SELECT_Detail_Engine = "Detail Engine Compartment";
        const string SELECT_Detail_Under = "Detail Under Carriage";

        // Declare Interior Constants
        const string SELECT_Fragrance = "Fragrance";
        const string SELECT_Shampoo = "Shampoo Carpets";
        const string SELECT_Coat = "Interior Protection Coat";
        const string SELECT_Upholstery = "Shampoo Upholstery";
        const string SELECT_Scotchguard = "Scotchguard";

        public Module7()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lbPackage.SelectedIndex != -1)
            {
                if (cbFragrance.SelectedIndex != -1)
                {
                    // Begin The Process For Print Preview
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Choose A Fragrance.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Choose A Package.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear The Package Selection
            lbPackage.SelectedIndex = -1;

            // Clear The Fragrance Selection
            cbFragrance.SelectedIndex = -1;

            // Clear The Selections
            clearSelections();

            // Set Focus On Package Selection
            lbPackage.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }

        private void lbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedPackageInt = lbPackage.SelectedIndex;

            if (selectedPackageInt == 0)
            {
                // Clear The Selections
                clearSelections();

                // Add Exterior Selections
                lbExterior.Items.Add(SELECT_Hand_Wash);

                // Add Interior Selections
                lbInterior.Items.Add(SELECT_Fragrance);
            }
            else if (selectedPackageInt == 1)
            {
                // Clear The Selections
                clearSelections();

                // Add Exterior Selections
                lbExterior.Items.Add(SELECT_Hand_Wash);
                lbExterior.Items.Add(SELECT_Hand_Wax);

                // Add Interior Selections
                lbInterior.Items.Add(SELECT_Fragrance);
                lbInterior.Items.Add(SELECT_Shampoo);
            }
            else if (selectedPackageInt == 2)
            {
                // Clear The Selections
                clearSelections();

                // Add Exterior Selections
                lbExterior.Items.Add(SELECT_Hand_Wash);
                lbExterior.Items.Add(SELECT_Hand_Wax);
                lbExterior.Items.Add(SELECT_Check_Fluid);

                // Add Interior Selections
                lbInterior.Items.Add(SELECT_Fragrance);
                lbInterior.Items.Add(SELECT_Shampoo);
                lbInterior.Items.Add(SELECT_Coat);
            }
            else if (selectedPackageInt == 3)
            {
                // Clear The Selections
                clearSelections();

                // Add Exterior Selections
                lbExterior.Items.Add(SELECT_Hand_Wash);
                lbExterior.Items.Add(SELECT_Hand_Wax);
                lbExterior.Items.Add(SELECT_Check_Fluid);
                lbExterior.Items.Add(SELECT_Detail_Engine);
                lbExterior.Items.Add(SELECT_Detail_Under);

                // Add Interior Selections
                lbInterior.Items.Add(SELECT_Fragrance);
                lbInterior.Items.Add(SELECT_Shampoo);
                lbInterior.Items.Add(SELECT_Upholstery);
                lbInterior.Items.Add(SELECT_Scotchguard);
            }
        }

        private void clearSelections()
        {
            // Clear The Exterior Selections
            lbExterior.Items.Clear();

            // Clear The Interior Selections
            lbInterior.Items.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print Setup
            Font titleFont = new Font("Tahoma", 14, FontStyle.Bold);
            Font headFont = new Font("Tahoma", 12, FontStyle.Italic);
            Font printFont = new Font("Tahoma", 12);
            float verticalPrintPositionFloat = e.MarginBounds.Top;
            float horizontalPrintPositionFloat = e.MarginBounds.Left;
            float lineHeightFloat = printFont.GetHeight();

            // Print Heading
            e.Graphics.DrawString("Christopher's Car Center", titleFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 1 * lineHeightFloat;

            // Print Programmer Name
            e.Graphics.DrawString("Programmer: C. Anderson", printFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 2 * lineHeightFloat;

            // Print Package Choice
            string choicePackage = lbPackage.Items[lbPackage.SelectedIndex].ToString();
            e.Graphics.DrawString(choicePackage + " Detail Package Includes", printFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 2 * lineHeightFloat;

            // Print Exterior Header
            e.Graphics.DrawString("Exterior:", headFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 1 * lineHeightFloat;

            // Printer Exterior Choices
            for (int indexInteger = 0; indexInteger <= lbExterior.Items.Count - 1; indexInteger++)
            {
                string exteriorString = lbExterior.Items[indexInteger].ToString();
                e.Graphics.DrawString(exteriorString,printFont,Brushes.Black,horizontalPrintPositionFloat,verticalPrintPositionFloat);
                verticalPrintPositionFloat += 1 * lineHeightFloat;
            }

            // Print Interior Header
            verticalPrintPositionFloat += 1 * lineHeightFloat;
            e.Graphics.DrawString("Interior:", headFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 1 * lineHeightFloat;

            // Printer Exterior Choices
            for (int indexInteger = 0; indexInteger <= lbInterior.Items.Count - 1; indexInteger++)
            {
                string interiorString = lbInterior.Items[indexInteger].ToString();
                e.Graphics.DrawString(interiorString, printFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
                verticalPrintPositionFloat += 1 * lineHeightFloat;
            }

            // Print Fragrance Header
            verticalPrintPositionFloat += 1 * lineHeightFloat;
            e.Graphics.DrawString("Fragrance Selected:", headFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
            verticalPrintPositionFloat += 1 * lineHeightFloat;

            // Print Fragrance Choice
            string fragranceChoice = cbFragrance.Items[cbFragrance.SelectedIndex].ToString();
            e.Graphics.DrawString(fragranceChoice, printFont, Brushes.Black, horizontalPrintPositionFloat, verticalPrintPositionFloat);
        }
    }
}