//****************************************************************************************************
// Program Name:    Chapter 8 Case Study, State Names And Abbreviations
// Programmer:      Christopher M. Anderson
// Date:            04.21.08
// Purpose:         Arrays
//****************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Module8_4
{
    public partial class Module8_4 : Form
    {

        // Establish The Structure
        public struct StateInfo
        {
            public string stateName;
            public string stateAbb;
        }

        // Declare The Array
        public StateInfo[] arrayGroup = new StateInfo[56];

        public Module8_4()
        {
            InitializeComponent();
        }

        // Load The Form
        private void Module8_4_Load(object sender, EventArgs e)
        {
            // Load The State Names
            arrayGroup[0].stateName = "ALABAMA";
            arrayGroup[1].stateName = "ALASKA";
            arrayGroup[2].stateName = "AMERICAN SAMOA";
            arrayGroup[3].stateName = "ARIZONA";
            arrayGroup[4].stateName = "ARKANSAS";
            arrayGroup[5].stateName = "CALIFORNIA";
            arrayGroup[6].stateName = "COLORADO";
            arrayGroup[7].stateName = "CONNECTICUT";
            arrayGroup[8].stateName = "DELAWARE";
            arrayGroup[9].stateName = "DISTRICT OF COLUMBIA";
            arrayGroup[10].stateName = "FLORIDA";
            arrayGroup[11].stateName = "GEORGIA";
            arrayGroup[12].stateName = "GUAM";
            arrayGroup[13].stateName = "HAWAII";
            arrayGroup[14].stateName = "IDAHO";
            arrayGroup[15].stateName = "ILLINOIS";
            arrayGroup[16].stateName = "INDIANA";
            arrayGroup[17].stateName = "IOWA";
            arrayGroup[18].stateName = "KANSAS";
            arrayGroup[19].stateName = "KENTUCKY";
            arrayGroup[20].stateName = "LOUISIANA";
            arrayGroup[21].stateName = "MAINE";
            arrayGroup[22].stateName = "MARYLAND";
            arrayGroup[23].stateName = "MASSACHUSETTS";
            arrayGroup[24].stateName = "MICHIGAN";
            arrayGroup[25].stateName = "MINNESOTA";
            arrayGroup[26].stateName = "MISSISSIPPI";
            arrayGroup[27].stateName = "MISSOURI";
            arrayGroup[28].stateName = "MONTANA";
            arrayGroup[29].stateName = "NEBRASKA";
            arrayGroup[30].stateName = "NEVADA";
            arrayGroup[31].stateName = "NEW HAMPSHIRE";
            arrayGroup[32].stateName = "NEW JERSEY";
            arrayGroup[33].stateName = "NEW MEXICO";
            arrayGroup[34].stateName = "NEW YORK";
            arrayGroup[35].stateName = "NORTH CAROLINA";
            arrayGroup[36].stateName = "NORTH DAKOTA";
            arrayGroup[37].stateName = "OHIO";
            arrayGroup[38].stateName = "OKLAHOMA";
            arrayGroup[39].stateName = "OREGON";
            arrayGroup[40].stateName = "PENNSYLVANIA";
            arrayGroup[41].stateName = "PUERTO RICO";
            arrayGroup[42].stateName = "RHODE ISLAND";
            arrayGroup[43].stateName = "SOUTH CAROLINA";
            arrayGroup[44].stateName = "SOUTH DAKOTA";
            arrayGroup[45].stateName = "TENNESSEE";
            arrayGroup[46].stateName = "TEXAS";
            arrayGroup[47].stateName = "TRUST TERRITORIES";
            arrayGroup[48].stateName = "UTAH";
            arrayGroup[49].stateName = "VERMONT";
            arrayGroup[50].stateName = "VIRGINIA";
            arrayGroup[51].stateName = "VIRGIN ISLANDS";
            arrayGroup[52].stateName = "WASHINGTON";
            arrayGroup[53].stateName = "WEST VIRGINIA";
            arrayGroup[54].stateName = "WISCONSIN";
            arrayGroup[55].stateName = "WYOMING";

            // Load The State Abbreviations
            arrayGroup[0].stateAbb = "AL";
            arrayGroup[1].stateAbb = "AK";
            arrayGroup[2].stateAbb = "AS";
            arrayGroup[3].stateAbb = "AZ";
            arrayGroup[4].stateAbb = "AR";
            arrayGroup[5].stateAbb = "CA";
            arrayGroup[6].stateAbb = "CO";
            arrayGroup[7].stateAbb = "CT";
            arrayGroup[8].stateAbb = "DE";
            arrayGroup[9].stateAbb = "DC";
            arrayGroup[10].stateAbb = "FL";
            arrayGroup[11].stateAbb = "GA";
            arrayGroup[12].stateAbb = "GU";
            arrayGroup[13].stateAbb = "HI";
            arrayGroup[14].stateAbb = "ID";
            arrayGroup[15].stateAbb = "IL";
            arrayGroup[16].stateAbb = "IN";
            arrayGroup[17].stateAbb = "IA";
            arrayGroup[18].stateAbb = "KS";
            arrayGroup[19].stateAbb = "KY";
            arrayGroup[20].stateAbb = "LA";
            arrayGroup[21].stateAbb = "ME";
            arrayGroup[22].stateAbb = "MD";
            arrayGroup[23].stateAbb = "MA";
            arrayGroup[24].stateAbb = "MI";
            arrayGroup[25].stateAbb = "MN";
            arrayGroup[26].stateAbb = "MS";
            arrayGroup[27].stateAbb = "MO";
            arrayGroup[28].stateAbb = "MT";
            arrayGroup[29].stateAbb = "NE";
            arrayGroup[30].stateAbb = "NV";
            arrayGroup[31].stateAbb = "NH";
            arrayGroup[32].stateAbb = "NJ";
            arrayGroup[33].stateAbb = "NM";
            arrayGroup[34].stateAbb = "NY";
            arrayGroup[35].stateAbb = "NC";
            arrayGroup[36].stateAbb = "ND";
            arrayGroup[37].stateAbb = "OH";
            arrayGroup[38].stateAbb = "OK";
            arrayGroup[39].stateAbb = "OR";
            arrayGroup[40].stateAbb = "PA";
            arrayGroup[41].stateAbb = "PR";
            arrayGroup[42].stateAbb = "RI";
            arrayGroup[43].stateAbb = "SC";
            arrayGroup[44].stateAbb = "SD";
            arrayGroup[45].stateAbb = "TN";
            arrayGroup[46].stateAbb = "TX";
            arrayGroup[47].stateAbb = "TT";
            arrayGroup[48].stateAbb = "UT";
            arrayGroup[49].stateAbb = "VT";
            arrayGroup[50].stateAbb = "VA";
            arrayGroup[51].stateAbb = "VI";
            arrayGroup[52].stateAbb = "WA";
            arrayGroup[53].stateAbb = "WV";
            arrayGroup[54].stateAbb = "WI";
            arrayGroup[55].stateAbb = "WY";
        }

        private void rbAbb_CheckedChanged(object sender, EventArgs e)
        {
            // Cast The Sender Argument To A Radio Button Data Type
            RadioButton selectedRadioButton = (RadioButton)sender;

            // Set Text Boxes Based On Radio Choice
            switch (selectedRadioButton.Name)
            {
                case "rbAbb":
                    tbAbb.ReadOnly = true;
                    tbName.ReadOnly = false;
                    tbAbb.Clear();
                    tbName.Clear();
                    break;
                case "rbName":
                    tbAbb.ReadOnly = false;
                    tbName.ReadOnly = true;
                    tbAbb.Clear();
                    tbName.Clear();
                    break;
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {

            // Define Index Integer
            int indexInteger = 0;

            // Definte State Integer
            int stateInteger = -1;

            // Define State Found Boolean
            bool stateFoundBool = false;

            // Determine If Searching For Name Or Abbreviation
            if (tbName.ReadOnly)
            {
                while (!stateFoundBool && indexInteger < 56)
                {
                    if (tbAbb.Text.ToUpper() == arrayGroup[indexInteger].stateAbb)
                    {
                        stateInteger = indexInteger;
                        stateFoundBool = true;
                    }
                    indexInteger++;
                }
            }
            else
            {
                while (!stateFoundBool && indexInteger < 56)
                {
                    if (tbName.Text.ToUpper() == arrayGroup[indexInteger].stateName)
                    {
                        stateInteger = indexInteger;
                        stateFoundBool = true;
                    }
                    indexInteger++;
                }
            }

            // Display Requested Answer Or Display Error
            if (stateFoundBool)
            {
                if (tbName.ReadOnly)
                {
                    tbName.Text = arrayGroup[stateInteger].stateName.ToString();
                }
                else
                {
                    tbAbb.Text = arrayGroup[stateInteger].stateAbb.ToString();
                }
            }
            else
            {
                MessageBox.Show("The state you are looking for could not be found. Please check your spelling, then try again.", "No Match Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Form
            tbName.Clear();
            tbAbb.Clear();

            // Set Focus
            rbAbb.Checked = true;
            tbName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit The Program
            this.Close();
        }
    }
}