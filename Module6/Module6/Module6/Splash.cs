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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Close The Splash Form
            this.Close();
        }
    }
}